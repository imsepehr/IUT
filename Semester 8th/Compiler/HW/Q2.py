import pydot
from IPython.display import Image, display
import re


def tokenize_input(input_str):
    token_specification = [
        ("ID", r"id"),  
        ("PLUS", r"\+"),  
        ("TIMES", r"\*"),  
        ("LPAREN", r"\("),    
        ("RPAREN", r"\)"),    
        ("SKIP", r"[ \t]+"),       
        ("MISMATCH", r"."),   
    ]
    token_regex = "|".join(f"(?P<{pair[0]}>{pair[1]})" for pair in token_specification)
    tokens = []
    for mo in re.finditer(token_regex, input_str):
        kind = mo.lastgroup
        value = mo.group()
        if kind == "ID":
            tokens.append("id")
        elif kind == "PLUS":
            tokens.append("+")
        elif kind == "TIMES":
            tokens.append("*")
        elif kind == "LPAREN":
            tokens.append("(")
        elif kind == "RPAREN":
            tokens.append(")")
        elif kind == "SKIP":
            continue
        elif kind == "MISMATCH":
            raise SyntaxError(f"Unexpected character: {value}")
    tokens.append("$")
    return tokens

ll1_parse_table = {
    "E": {"id": "T E'", "(": "T E'"},
    "E'": {"+": "+ T E'", ")": "ε", "$": "ε"},
    "T": {"id": "F T'", "(": "F T'"},
    "T'": {"+": "ε", "*": "* F T'", ")": "ε", "$": "ε"},
    "F": {"id": "id", "(": "( E )"},
}

grammar_rules = {
    "E": ["T E'"],
    "E'": ["+ T E'", "ε"],
    "T": ["F T'"],
    "T'": ["* F T'", "ε"],
    "F": ["( E )", "id"],
}

def parse_input(tokens):
    stack = ["$", "E"]
    index = 0
    parse_tree = []
    node_id = 0

    def add_tree_node(parent_id, label):
        nonlocal node_id
        node_id += 1
        parse_tree.append((parent_id, node_id, label))
        return node_id

    root_id = add_tree_node(None, "E")
    node_stack = [root_id]

    while stack:
        top = stack.pop()
        current_token = tokens[index]

        print(f"Stack: {stack}, Current Token: {current_token}, Top: {top}")

        if top == current_token:
            index += 1
            if node_stack:
                node_stack.pop()
        elif top in ll1_parse_table:
            production = ll1_parse_table[top].get(current_token)
            if production:
                print(f"Production: {top} -> {production}")
                parent_id = node_stack[-1]
                if production != "ε":
                    children = []
                    for symbol in reversed(production.split()):
                        stack.append(symbol)
                        child_id = add_tree_node(parent_id, symbol)
                        children.append(child_id)
                        node_stack.append(child_id)
                else:
                    node_stack.pop()
            else:
                raise SyntaxError(f"Unexpected symbol: {current_token}")
        elif top != "ε":
            raise SyntaxError(f"Unexpected symbol: {current_token}")

    return parse_tree

def display_parse_tree(parse_tree):
    graph = pydot.Dot(graph_type="digraph")

    nodes = {}
    for parent_id, node_id, label in parse_tree:
        node = pydot.Node(node_id, label=label)
        graph.add_node(node)
        nodes[node_id] = node
        if parent_id is not None:
            graph.add_edge(pydot.Edge(nodes[parent_id], node))

    graph.write_png("parse_tree.png")
    display(Image(filename="parse_tree.png"))

input_str = "id+id*id"

tokens = tokenize_input(input_str)
print(f"Tokens: {tokens}")

try:
    parse_tree = parse_input(tokens)
    display_parse_tree(parse_tree)
    print("Parse tree successfully generated: 'parse_tree.png'.")
except SyntaxError as e:
    print(e)
