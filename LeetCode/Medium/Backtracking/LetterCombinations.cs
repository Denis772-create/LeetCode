namespace LeetCode.Medium.Backtracking;

using System.Collections.Generic;

/// <summary>
/// 17. Letter Combinations of a Phone Number
///
/// Идея:
/// Дана строка из цифр 2–9, каждая соответствует набору букв на клавиатуре телефона.
/// Нужно вернуть все возможные комбинации букв, которые можно составить.
///
/// Пример:
/// digits = "23"
/// → ["ad","ae","af","bd","be","bf","cd","ce","cf"]
///
/// Подход (Backtracking / DFS):
/// 1️⃣ Строим карту соответствий цифра → буквы (2 → "abc", 3 → "def" и т.д.)
/// 2️⃣ Запускаем DFS (глубокий поиск):
///     - На каждом уровне выбираем одну букву для текущей цифры.
///     - Когда длина собранного слова == длине digits → добавляем в результат.
/// 3️⃣ Возвращаем список всех возможных комбинаций.
///
/// Отличается от простого цикла тем, что перебирает все ветви "дерева решений".
/// </summary>
public class Solution
{
    // Словарь: цифра -> набор букв
    private static readonly Dictionary<char, string> map = new()
    {
        ['2'] = "abc",
        ['3'] = "def",
        ['4'] = "ghi",
        ['5'] = "jkl",
        ['6'] = "mno",
        ['7'] = "pqrs",
        ['8'] = "tuv",
        ['9'] = "wxyz"
    };
    
    public IList<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if (string.IsNullOrEmpty(digits))
            return res;

        // Временный буфер для сборки текущей комбинации
        var path = new char[digits.Length];

        // Рекурсивная функция: i — текущая позиция в digits
        void Dfs(int i)
        {
            // Базовый случай: собрали комбинацию целиком
            if (i == digits.Length)
            {
                res.Add(new string(path));
                return;
            }

            // Берём все буквы для текущей цифры
            if (!map.TryGetValue(digits[i], out var letters))
                return; // если цифра не из диапазона 2–9

            // Перебираем все варианты для этой цифры
            foreach (var ch in letters)
            {
                path[i] = ch;
                Dfs(i + 1); // переходим к следующей цифре
            }
        }

        Dfs(0);
        return res;
    }
}
