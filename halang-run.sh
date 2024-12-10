#!/bin/bash

# Compile the HaLang program
csc -out:lexer.exe lexer.cs
python parser.py program.halang

# Run the compiled program
mono lexer.exe program.halang
