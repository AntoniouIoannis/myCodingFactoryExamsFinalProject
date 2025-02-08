import csv

input_file_path = "monuments.txt"
output_csv_path = "monuments.csv"  # Το νέο .csv αρχείο

# Ανάγνωση του .txt αρχείου
with open(input_file_path, 'r', encoding='utf-8') as file:
    lines = file.readlines()

# Δημιουργία του .csv αρχείου
with open(output_csv_path, 'w', encoding='utf-8', newline='') as csv_file:
    writer = csv.writer(csv_file)
    
        
    # Επεξεργασία γραμμών
    for i, line in enumerate(lines, start=1):
        parts = line.strip().split(',\t')  # Διαχωρισμός με tab
        name = f"'{name[0]}'"  # Προσθήκη αποστρόφων
        location = f"'{location[i]}'"  # Προσθήκη αποστρόφων
        formatted_line = f"([{i}, {name}, {location}, '),'])"  # Προσθήκη παρένθεσης και κόμματος

        writer.writerow([i, name, location])  # Γράψιμο στο .csv αρχείο
        
