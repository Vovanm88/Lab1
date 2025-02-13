def solve():
    with open('Lab1/resources/0013_numbers.txt', 'r') as file:
        numbers = [int(line.strip()) for line in file]
    total_sum = sum(numbers)
    return str(total_sum)[:10]

if __name__ == "__main__":
    print(solve())