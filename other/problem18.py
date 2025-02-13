def solve():
    # Читаем треугольник из файла
    with open('Lab1/resources/0018_triangle.txt', 'r') as file:
        triangle = [[int(num) for num in line.strip().split()] for line in file]
    
    # Копируем последнюю строку треугольника
    dp = triangle[-1].copy()
    
    # Идем снизу вверх
    for row in range(len(triangle) - 2, -1, -1):
        new_row = [0] * (row + 1)
        for col in range(row + 1):
            # Для каждого элемента выбираем максимальный путь
            new_row[col] = triangle[row][col] + max(dp[col], dp[col + 1])
        dp = new_row
    
    return dp[0]

if __name__ == "__main__":
    print(solve())