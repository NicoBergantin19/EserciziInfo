from genericpath import exists
import hashlib
import sys
import os

def controllo_file(self, filename):
    file_exists = exists(filename)
    if(file_exists == False):
        print("Il file non esiste")
        exit()

def hash_file(self, filename):
    file = open(filename, 'rb')
    stringaSHA = ''
    while True:
        dati = os.read(filename, 4096)
        if (dati == False):
            break
        stringaSHA += hashlib.sha256(dati).hexdigest()

    print(stringaSHA)

controllo_file(sys.argv[1])
hash_file(sys.argv[1])