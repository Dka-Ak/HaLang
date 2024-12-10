import json

def parse(tokens):
    # Parsing logic here
    return {}

def main():
    with open('program.halang', 'r') as file:
        code = file.read()
    tokens = code.split()  # Simplified tokenization
    ast = parse(tokens)
    with open('ast.json', 'w') as file:
        json.dump(ast, file)

if __name__ == "__main__":
    main()
