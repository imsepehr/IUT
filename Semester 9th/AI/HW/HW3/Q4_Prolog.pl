/*
Author : Sepehr Ebadi
Student Number : 9933243
Fall 1403
Course : AI
Professor : Dr.Palhang
*/

color(red).
color(green).
color(blue).
color(yellow).
/*color(black).
color(pink).*/

neighbor(esfahan, yazd).
neighbor(esfahan, fars).
neighbor(esfahan, chaharmahal).
neighbor(esfahan, lorestan).
neighbor(esfahan, markazi).
neighbor(yazd, fars).
neighbor(chaharmahal, lorestan).
neighbor(lorestan, markazi).
neighbor(lorestan, hamedan).
neighbor(kordestan, hamedan).
neighbor(hamedan, markazi).

mapcoloringiran(Sol) :-
    Nodes = [esfahan, yazd, fars, chaharmahal, lorestan, kordestan, markazi, hamedan],
    depthFirst([], Nodes, Sol).

depthFirst(Sol, [], Sol).
depthFirst(Path, [Node | Tail], Sol) :-
    color(Color),
    safe(Node, Color, Path), 
    depthFirst([Node-Color | Path], Tail, Sol).

safe(Node, Color, Path) :-
    \+ (member(Neighbor-NeighborColor, Path), (neighbor(Node, Neighbor); neighbor(Neighbor, Node)), NeighborColor = Color).


