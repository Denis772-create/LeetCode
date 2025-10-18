# LeetCode

Структура и конвенции

- Уровни сложности: `LeetCode/Easy`, `LeetCode/Medium`.
- Тематические папки внутри уровней: `Arrays`, `Strings`, `TwoPointers`, `SlidingWindow`, `HashMap`, `BitManipulation`, `PrefixSum`, `Greedy`, `Queues`, `Stack`, `LinkedList`, `BinaryTree`.
- Имена файлов/классов: `LCxxxx_ProblemNameInPascalCase.cs`, класс `LcXXXXProblemNameInPascalCase`.
- Пространства имён: `LeetCode.<Difficulty>.<Topic>`.

Что внутри каждой задачи

- Краткое условие задачи (RU).
- Ключевая идея/подход (по шагам).
- Итоговая сложность: время и память.
- Чистая, краткая реализация.

Примеры

- Easy/Strings: `LC1768_MergeStringsAlternately` — два указателя, O(n) / O(n).
- Easy/SlidingWindow: `LC0643_MaximumAverageSubarrayI` — скользящее окно, O(n) / O(1).
- Medium/TwoPointers: `LC0011_ContainerWithMostWater` — два указателя, O(n) / O(1).

Запуск

- Точка входа `LeetCode/Program.cs`. Добавляйте локальные пробы вызовов при необходимости.