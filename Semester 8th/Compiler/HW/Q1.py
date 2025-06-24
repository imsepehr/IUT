import os

def eliminate_left_recursion(grammar):
    updated_grammar = {}
    for non_term in grammar:
        direct_recursions = []
        non_recursions = []
        for prod in grammar[non_term]:
            if prod.startswith(non_term):
                direct_recursions.append(prod[len(non_term):])
            else:
                non_recursions.append(prod)
        if direct_recursions:
            new_non_term = non_term + "_prime"
            updated_grammar[non_term] = [b + new_non_term for b in non_recursions]
            updated_grammar[new_non_term] = [a + new_non_term for a in direct_recursions] + ["ε"]
        else:
            updated_grammar[non_term] = grammar[non_term]
    return updated_grammar


def factor_out_common_prefixes(grammar):
    factored_grammar = {}
    for non_term, prods in grammar.items():
        if len(prods) > 1:
            common_prefix = os.path.commonprefix(prods)
            if common_prefix:
                new_non_term = non_term + "_factored"
                factored_grammar[non_term] = [common_prefix + new_non_term]
                factored_grammar[new_non_term] = [p[len(common_prefix):] for p in prods]
            else:
                factored_grammar[non_term] = prods
        else:
            factored_grammar[non_term] = prods
    return factored_grammar


def transform_grammar(input_grammar):
    parsed_grammar = {key: [p.strip() for p in val] for key, val in input_grammar.items()}
    parsed_grammar = eliminate_left_recursion(parsed_grammar)
    parsed_grammar = factor_out_common_prefixes(parsed_grammar)
    return parsed_grammar


def load_grammar_from_file(file_path):
    grammar = {}
    with open(file_path, "r") as file:
        for line in file:
            line = line.strip()
            if line and line[0] == "{" or line[-1] == "}":
                continue
            if line:
                key, value = line.split(":")
                productions = value.strip()[1:-1].split(", ")
                grammar[key.strip()] = productions
    return grammar


def save_grammar_to_file(file_path, grammar):
    with open(file_path, "w") as file:
        file.write("{\n")
        for key, prods in grammar.items():
            file.write(f"\t{key}: {prods}\n")
        file.write("}\n")


input_filename = "input_grammar.txt"
output_filename = "output_grammar.txt"

input_grammar = load_grammar_from_file(input_filename)

transformed_grammar = transform_grammar(input_grammar)

save_grammar_to_file(output_filename, transformed_grammar)

