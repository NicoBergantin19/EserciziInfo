from genericpath import exists
import hashlib
import sys

def Calcolo_Hash(filename):
    file = open(filename, 'rb')
    stringaSHA = hashlib.sha256()
    dati = 0
    while dati != b'':
        dati = file.read(4096)
        stringaSHA.update(dati)

    stringaSHA = stringaSHA.hexdigest().upper()
    return stringaSHA

def Controllo_File(filename):
    file_exists = exists(filename)
    if(file_exists == False):
        print("Il file non esiste")
        exit()

if(len(sys.argv) != 3):
    print(f'Usare {sys.argv[0]} file1 file2')
    exit(1)

filename = sys.argv[1]
daControllare = sys.argv[2]
Controllo_File(filename)

originaleSHA = Calcolo_Hash(daControllare)
stringaSHA = Calcolo_Hash(filename)

print(f'SHA256 di {filename}: {stringaSHA}')
print(f'SHA256 di {daControllare}: {originaleSHA}')

if(filename == daControllare):
    if(originaleSHA == stringaSHA):
        print("Hash SHA256 calcolato correttamente")
else:
    print("Sono stati inseriti dei file diversi")
    
