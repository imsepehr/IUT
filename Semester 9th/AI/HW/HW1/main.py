from knuth import KnuthProblem

if __name__ == "__main__":
    target = int(input("Number: "))
    
    problem = KnuthProblem()
    problem.problemSearch(target)