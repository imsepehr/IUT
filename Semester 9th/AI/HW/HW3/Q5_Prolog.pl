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
# color(yellow).
# color(black).
# color(pink).


% East Azerbaijan neighbors
neighbor(east_azerbaijan, west_azerbaijan).
neighbor(east_azerbaijan, ardabil).
neighbor(east_azerbaijan, zanjan).

% West Azerbaijan neighbors
neighbor(west_azerbaijan, east_azerbaijan).
neighbor(west_azerbaijan, kurdistan).
neighbor(west_azerbaijan, zanjan).

% Ardabil neighbors
neighbor(ardabil, east_azerbaijan).
neighbor(ardabil, gilan).
neighbor(ardabil, zanjan).

% Isfahan neighbors
neighbor(isfahan, chaharmahal_and_bakhtiari).
neighbor(isfahan, fars).
neighbor(isfahan, kohgiluyeh_and_boyer_ahmad).
neighbor(isfahan, yazd).
neighbor(isfahan, semnan).
neighbor(isfahan, markazi).
neighbor(isfahan, south_khorasan).
neighbor(isfahan, qom).
neighbor(isfahan, lorestan).



% Alborz neighbors
neighbor(alborz, tehran).
neighbor(alborz, qazvin).
neighbor(alborz, mazandaran).
neighbor(alborz, markazi).

% Ilam neighbors
neighbor(ilam, kermanshah).
neighbor(ilam, lorestan).
neighbor(ilam, khuzestan).

% Bushehr neighbors
neighbor(bushehr, fars).
neighbor(bushehr, kohgiluyeh_and_boyer_ahmad).
neighbor(bushehr, khuzestan).
neighbor(bushehr, hormozgan).

% Tehran neighbors
neighbor(tehran, alborz).
neighbor(tehran, mazandaran).
neighbor(tehran, semnan).
neighbor(tehran, qom).

% Chaharmahal and Bakhtiari neighbors
neighbor(chaharmahal_and_bakhtiari, isfahan).
neighbor(chaharmahal_and_bakhtiari, khuzestan).
neighbor(chaharmahal_and_bakhtiari, kohgiluyeh_and_boyer_ahmad).
neighbor(chaharmahal_and_bakhtiari, lorestan).

% South Khorasan neighbors
neighbor(south_khorasan, razavi_khorasan).
neighbor(south_khorasan, yazd).
neighbor(south_khorasan, kerman).
neighbor(south_khorasan, sistan_and_baluchestan).

% Razavi Khorasan neighbors
neighbor(razavi_khorasan, south_khorasan).
neighbor(razavi_khorasan, north_khorasan).
neighbor(razavi_khorasan, semnan).

% North Khorasan neighbors
neighbor(north_khorasan, razavi_khorasan).
neighbor(north_khorasan, golestan).
neighbor(north_khorasan, semnan).

% Khuzestan neighbors
neighbor(khuzestan, bushehr).
neighbor(khuzestan, kohgiluyeh_and_boyer_ahmad).
neighbor(khuzestan, chaharmahal_and_bakhtiari).
neighbor(khuzestan, lorestan).
neighbor(khuzestan, ilam).

% Zanjan neighbors
neighbor(zanjan, east_azerbaijan).
neighbor(zanjan, west_azerbaijan).
neighbor(zanjan, kurdistan).
neighbor(zanjan, hamadan).
neighbor(zanjan, qazvin).
neighbor(zanjan, gilan).
neighbor(zanjan, ardabil).

% Semnan neighbors
neighbor(semnan, golestan).
neighbor(semnan, mazandaran).
neighbor(semnan, tehran).
neighbor(semnan, isfahan).
neighbor(semnan, razavi_khorasan).
neighbor(semnan, north_khorasan).
neighbor(semnan, south_khorasan).
neighbor(semnan, qom).



% Sistan and Baluchestan neighbors
neighbor(sistan_and_baluchestan, south_khorasan).
neighbor(sistan_and_baluchestan, kerman).
neighbor(sistan_and_baluchestan, hormozgan).

% Fars neighbors
neighbor(fars, isfahan).
neighbor(fars, yazd).
neighbor(fars, kerman).
neighbor(fars, hormozgan).
neighbor(fars, bushehr).
neighbor(fars, kohgiluyeh_and_boyer_ahmad).

% Qazvin neighbors
neighbor(qazvin, zanjan).
neighbor(qazvin, gilan).
neighbor(qazvin, mazandaran).
neighbor(qazvin, alborz).
neighbor(qazvin, markazi).

% Qom neighbors
neighbor(qom, tehran).
neighbor(qom, semnan).
neighbor(qom, isfahan).
neighbor(qom, markazi).

% Kurdistan neighbors
neighbor(kurdistan, west_azerbaijan).
neighbor(kurdistan, zanjan).
neighbor(kurdistan, hamadan).
neighbor(kurdistan, kermanshah).

% Kerman neighbors
neighbor(kerman, south_khorasan).
neighbor(kerman, yazd).
neighbor(kerman, fars).
neighbor(kerman, hormozgan).
neighbor(kerman, sistan_and_baluchestan).

% Kermanshah neighbors
neighbor(kermanshah, kurdistan).
neighbor(kermanshah, hamadan).
neighbor(kermanshah, lorestan).
neighbor(kermanshah, ilam).

% Kohgiluyeh and Boyer-Ahmad neighbors
neighbor(kohgiluyeh_and_boyer_ahmad, isfahan).
neighbor(kohgiluyeh_and_boyer_ahmad, fars).
neighbor(kohgiluyeh_and_boyer_ahmad, bushehr).
neighbor(kohgiluyeh_and_boyer_ahmad, khuzestan).
neighbor(kohgiluyeh_and_boyer_ahmad, chaharmahal_and_bakhtiari).

% Golestan neighbors
neighbor(golestan, north_khorasan).
neighbor(golestan, semnan).
neighbor(golestan, mazandaran).

% Gilan neighbors
neighbor(gilan, ardabil).
neighbor(gilan, zanjan).
neighbor(gilan, qazvin).
neighbor(gilan, mazandaran).

% Lorestan neighbors
neighbor(lorestan, kermanshah).
neighbor(lorestan, hamadan).
neighbor(lorestan, markazi).
neighbor(lorestan, isfahan).
neighbor(lorestan, chaharmahal_and_bakhtiari).
neighbor(lorestan, khuzestan).
neighbor(lorestan, ilam).

% Mazandaran neighbors
neighbor(mazandaran, gilan).
neighbor(mazandaran, qazvin).
neighbor(mazandaran, alborz).
neighbor(mazandaran, tehran).
neighbor(mazandaran, semnan).
neighbor(mazandaran, golestan).

% Markazi neighbors
neighbor(markazi, hamadan).
neighbor(markazi, qazvin).
neighbor(markazi, alborz).
neighbor(markazi, qom).
neighbor(markazi, isfahan).
neighbor(markazi, lorestan).

% Hormozgan neighbors
neighbor(hormozgan, kerman).
neighbor(hormozgan, fars).
neighbor(hormozgan, bushehr).
neighbor(hormozgan, sistan_and_baluchestan).

% Hamadan neighbors
neighbor(hamadan, kurdistan).
neighbor(hamadan, zanjan).
neighbor(hamadan, qazvin).
neighbor(hamadan, markazi).
neighbor(hamadan, lorestan).
neighbor(hamadan, kermanshah).

% Yazd neighbors
neighbor(yazd, isfahan).
neighbor(yazd, south_khorasan).
neighbor(yazd, kerman).
neighbor(yazd, fars).


mapcoloringiran(Sol) :-
    Nodes = [isfahan, yazd, fars, chaharmahal_and_bakhtiari, lorestan, kurdistan, markazi, hamadan, khuzestan, kermanshah, hormozgan, sistan_and_baluchestan, kerman, bushehr, kohgiluyeh_and_boyer_ahmad, ilam, qazvin, alborz, tehran, mazandaran, golestan, semnan, razavi_khorasan, south_khorasan, north_khorasan, ardabil, gilan, zanjan, east_azerbaijan, west_azerbaijan, qom],
    depthFirst([], Nodes, Sol).

depthFirst(Sol, [], Sol).
depthFirst(Path, [Node | Tail], Sol) :-
    color(Color),
    safe(Node, Color, Path), 
    depthFirst([Node-Color | Path], Tail, Sol).

safe(Node, Color, Path) :-
    \+ (member(Neighbor-NeighborColor, Path), (neighbor(Node, Neighbor); neighbor(Neighbor, Node)), NeighborColor = Color).


