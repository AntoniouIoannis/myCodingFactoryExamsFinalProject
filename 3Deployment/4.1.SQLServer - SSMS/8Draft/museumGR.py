import requests
from bs4 import BeautifulSoup
import pandas as pd
import os
import time

# Ορισμός της βασικής διεύθυνσης URL
BASE_URL = "https://archaeologicalmuseums.gr"

# Διεύθυνση της σελίδας με όλα τα μουσεία
MUSEUMS_URL = f"{BASE_URL}/el/museums"

# Επικεφαλίδες για το HTTP αίτημα
HEADERS = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64)"
}

def get_museum_links():
    """
    Λειτουργία για τη συλλογή όλων των συνδέσμων προς τα μουσεία.
    """
    response = requests.get(MUSEUMS_URL, headers=HEADERS)
    if response.status_code != 200:
        print(f"Αποτυχία πρόσβασης στη σελίδα: {MUSEUMS_URL}")
        return []

    soup = BeautifulSoup(response.content, "html.parser")
    # Υποθέτουμε ότι οι σύνδεσμοι των μουσείων βρίσκονται σε <a> tags με συγκεκριμένη κλάση
    # Αυτό μπορεί να χρειαστεί προσαρμογή ανάλογα με την πραγματική δομή της ιστοσελίδας
    museum_links = []
    for a_tag in soup.find_all('a', href=True):
        href = a_tag['href']
        if "/el/museum/" in href:
            full_url = BASE_URL + href
            if full_url not in museum_links:
                museum_links.append(full_url)
    
    print(f"Βρέθηκαν {len(museum_links)} σύνδεσμοι για μουσεία.")
    return museum_links

def scrape_museum_data(url):
    """
    Λειτουργία για τη συλλογή δεδομένων ενός μουσείου από τη σελίδα του.
    """
    response = requests.get(url, headers=HEADERS)
    if response.status_code != 200:
        print(f"Αποτυχία πρόσβασης στη σελίδα: {url}")
        return None

    soup = BeautifulSoup(response.content, "html.parser")
    
    # Ανάλογα με τη δομή της σελίδας, προσαρμόζουμε την εξαγωγή των δεδομένων
    try:
        # Όνομα
        name = soup.find('h1').get_text(strip=True)

        # Περιγραφή
        description = soup.find('div', class_='museum-description').get_text(strip=True)

        # Λειτουργίες (Μήνες και Ώρες)
        operations = soup.find('div', class_='museum-operations').get_text(strip=True)
        months = operations.split(',')[0].strip()
        hours = operations.split(',')[1].strip() if ',' in operations else ''

        # Τηλέφωνο
        phone = soup.find('span', class_='phone').get_text(strip=True)

        # Διεύθυνση
        address = soup.find('span', class_='address').get_text(strip=True)

        # Συντεταγμένες
        coordinates = soup.find('span', class_='coordinates').get_text(strip=True)

        return {
            "Όνομα": name,
            "Περιγραφή": description,
            "Μήνες Λειτουργίας": months,
            "Ώρες Λειτουργίας": hours,
            "Τηλέφωνο": phone,
            "Διεύθυνση": address,
            "Συντεταγμένες": coordinates
        }
    except AttributeError as e:
        print(f"Σφάλμα κατά την εξαγωγή δεδομένων από: {url}")
        return None

def main():
    # Δημιουργία του φακέλου αν δεν υπάρχει
    output_folder = r"C:/CultureGR"
    if not os.path.exists(output_folder):
        os.makedirs(output_folder)
        print(f"Δημιουργήθηκε ο φάκελος: {output_folder}")

    # Συλλογή συνδέσμων προς όλα τα μουσεία
    museum_links = get_museum_links()

    # Λίστα για αποθήκευση των δεδομένων
    museums_data = []

    for idx, link in enumerate(museum_links, start=1):
        print(f"Συλλογή δεδομένων μουσείου {idx}/{len(museum_links)}: {link}")
        data = scrape_museum_data(link)
        if data:
            museums_data.append(data)
        time.sleep(1)  # Καθυστέρηση για αποφυγή υπερφόρτωσης του διακομιστή

    # Δημιουργία DataFrame και αποθήκευση σε CSV
    df = pd.DataFrame(museums_data)
    output_path = os.path.join(output_folder, "museums_data.csv")
    df.to_csv(output_path, index=False, encoding='utf-8-sig')
    print(f"Τα δεδομένα αποθηκεύτηκαν στο: {output_path}")

if __name__ == "__main__":
    main()
