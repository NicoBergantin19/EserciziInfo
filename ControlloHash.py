from genericpath import exists
import hashlib
import sys
import os

def controllo_file(filename):
    file_exists = exists(filename)
    if(file_exists == False):
        print("Il file non esiste")
        exit()

def hash_file(filename):
    file = open(filename, 'rb')
    stringaSHA = ''
    while True:
        dati = os.read(filename, 4096)
        if (dati == False):
            break
        stringaSHA += hashlib.sha256(dati).hexdigest()

    print(stringaSHA)

def controllo_hash(originale, calcolato):
    if(calcolato == originale):
        print("L'hash in SHA256 è stato calcolato correttamente")
    else:
        print("Calcolo non corretto")


originaleSHA = b'8FCAF8DF9E5DA18EEBD38B9EA4E47C0D51A64EFF2F9B600978430F535CFA0BFE' #inserire sha originale // calcolarlo
controllo_file(sys.argv[1])
calcolato = hash_file(sys.argv[1])
controllo_hash(originaleSHA, calcolato)
