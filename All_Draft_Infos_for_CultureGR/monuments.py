import requests
from bs4 import BeautifulSoup
import pandas as pd
import os
import time

# Βασική διεύθυνση URL
BASE_URL = "http://odysseus.culture.gr/h/2/gh21.html"

# Σελίδα με όλα τα μνημεία
MNIMIA_URL = f"{BASE_URL}/h/2/gh21.jsp?theme_id=22"

# Επικεφαλίδες για HTTP αιτήματα
HEADERS = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64)"
}

def get_monument_links():
    """
    Λειτουργία για τη συλλογή συνδέσμων προς τις σελίδες των μνημείων.
    """
    response = requests.get(MNIMIA_URL, headers=HEADERS)
    if response.status_code != 200:
        print(f"Αποτυχία πρόσβασης στη σελίδα: {MNIMIA_URL}")
        return []

    soup = BeautifulSoup(response.content, "html.parser")
    # Οι σύνδεσμοι των μνημείων βρίσκονται σε συγκεκριμένα <a> tags
    monument_links = []
    for a_tag in soup.find_all('a', href=True):
        href = a_tag['href']
        if "/h/2/gh251.jsp" in href:  # Προσαρμογή ανάλογα με τη δομή των συνδέσμων
            full_url = BASE_URL + href
            if full_url not in monument_links:
                monument_links.append(full_url)
    
    print(f"Βρέθηκαν {len(monument_links)} σύνδεσμοι για μνημεία.")
    return monument_links

def scrape_monument_data(url):
    """
    Λειτουργία για τη συλλογή δεδομένων ενός μνημείου από τη σελίδα του.
    """
    response = requests.get(url, headers=HEADERS)
    if response.status_code != 200:
        print(f"Αποτυχία πρόσβασης στη σελίδα: {url}")
        return None

    soup = BeautifulSoup(response.content, "html.parser")
    
    # Ανάλογα με τη δομή της σελίδας, εξάγουμε τα δεδομένα
    try:
        # Όνομα μνημείου
        name = soup.find('h2').get_text(strip=True)

        # Πληροφορίες
        info = soup.find('div', class_='content').get_text(strip=True)

        # Μήνες και ώρες λειτουργίας
        operation_div = soup.find('div', class_='operation')
        if operation_div:
            operation_text = operation_div.get_text(strip=True)
        else:
            operation_text = "Δεν υπάρχουν διαθέσιμες πληροφορίες."

        # Διεύθυνση
        address = soup.find('div', class_='address').get_text(strip=True)

        # Τηλέφωνο
        phone = soup.find('div', class_='phone').get_text(strip=True)

        return {
            "Όνομα Μνημείου": name,
            "Πληροφορίες": info,
            "Μήνες και Ώρες Λειτουργίας": operation_text,
            "Διεύθυνση": address,
            "Τηλέφωνο": phone
        }
    except AttributeError as e:
        print(f"Σφάλμα κατά την εξαγωγή δεδομένων από: {url}")
        return None

def main():
    # Δημιουργία φακέλου αν δεν υπάρχει
    output_folder = r"C:\CultureGR"
    if not os.path.exists(output_folder):
        os.makedirs(output_folder)
        print(f"Δημιουργήθηκε ο φάκελος: {output_folder}")

    # Συλλογή συνδέσμων για όλα τα μνημεία
    monument_links = get_monument_links()

    # Λίστα για αποθήκευση των δεδομένων
    monuments_data = []

    for idx, link in enumerate(monument_links, start=1):
        print(f"Συλλογή δεδομένων μνημείου {idx}/{len(monument_links)}: {link}")
        data = scrape_monument_data(link)
        if data:
            monuments_data.append(data)
        time.sleep(1)  # Καθυστέρηση για αποφυγή υπερφόρτωσης του διακομιστή

    # Δημιουργία DataFrame και αποθήκευση σε CSV
    df = pd.DataFrame(monuments_data)
    output_path = os.path.join(output_folder, "monuments_data.csv")
    df.to_csv(output_path, index=False, encoding='utf-8-sig')
    print(f"Τα δεδομένα αποθηκεύτηκαν στο: {output_path}")

if __name__ == "__main__":
    main()
