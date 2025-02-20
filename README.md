# Project Euler - Задачи 13 и 18

## Описание проекта
В данном репозитории представлены решения двух задач с Project Euler, реализованные на F# и Python.

### Задача 13 - Сумма больших чисел
Задача заключается в нахождении первых десяти цифр суммы ста 50-значных чисел. Реализованы два подхода:
- **Рекурсивный метод**: Использует встроенный тип `bigint` для работы с большими числами
- **Модульный метод**: Более компактное решение с использованием функционального стиля программирования

### Задача 18 - Максимальная сумма пути в треугольнике
Требуется найти максимальную сумму чисел при движении от вершины до основания треугольника. Представлены четыре различных подхода:
- **Рекурсивный**: Классическое решение с использованием рекурсии
- **Динамическое программирование**: Оптимизированное решение с использованием массива для хранения промежуточных результатов
- **Функциональный**: Элегантное решение в функциональном стиле с использованием `Array.reduce`
- **Последовательный**: Решение с использованием последовательностей (sequences) в F#


## Особенности реализации
- Все решения работают с входными данными из текстовых файлов
- Код написан с учетом принципов функционального программирования
- Реализации на Python предоставлены для сравнения подходов в разных языках
- Каждая задача имеет несколько различных решений, демонстрирующих разные подходы к проблеме

## Запуск
Для запуска F# решений необходимо использовать .NET среду выполнения.
Для Python-решений требуется Python 3.x.
