# Игры разума (C#)

[![hexlet-check](https://github.com/krasotun/c-sharp-project-431/actions/workflows/hexlet-check.yml/badge.svg)](https://github.com/krasotun/c-sharp-project-431/actions)

Погрузитесь в экосистему .NET, научитесь настраивать рабочее окружение. Освоите dotnet CLI — инструмент создания, сборки и запуска проектов, и CSharpier, форматтер кода. Поймёте, чем git отличается от GitHub, поработаете с внешними репозиториями. Получите опыт построения архитектуры полноценного приложения и написания чистого кода.

Учебный проект Хекслета: https://ru.hexlet.io/programs/c-sharp


## Стек

- Csharp

## Установка

<!-- Опишите установку: клонирование, зависимости, переменные окружения -->

```bash
git clone https://github.com/krasotun/c-sharp-project-431.git
cd c-sharp-project-431
```

## Использование

```bash
make setup     # сборка в папку dist
make run-dist  # запуск
```

После запуска выберите игру по номеру. В каждой игре нужно ответить правильно на 3 вопроса подряд, первая ошибка завершает игру.

### Приветствие

![Приветствие](docs/screenshots/greet.png)

### Проверка на чётность

| Победа | Поражение |
| --- | --- |
| ![Even — победа](docs/screenshots/even-win.png) | ![Even — поражение](docs/screenshots/even-lose.png) |

### Калькулятор

| Победа | Поражение |
| --- | --- |
| ![Calc — победа](docs/screenshots/calc-win.png) | ![Calc — поражение](docs/screenshots/calc-lose.png) |

### НОД

| Победа | Поражение |
| --- | --- |
| ![GCD — победа](docs/screenshots/gcd-win.png) | ![GCD — поражение](docs/screenshots/gcd-lose.png) |

### Арифметическая прогрессия

| Победа | Поражение |
| --- | --- |
| ![Progression — победа](docs/screenshots/progression-win.png) | ![Progression — поражение](docs/screenshots/progression-lose.png) |

### Простое ли число?

| Победа | Поражение |
| --- | --- |
| ![Prime — победа](docs/screenshots/prime-win.png) | ![Prime — поражение](docs/screenshots/prime-lose.png) |

---

<details>
<summary>Автоматические тесты Хекслета</summary>

Тесты запускаются на каждый коммит. За запуск отвечает файл `.github/workflows/hexlet-check.yml` — не удаляйте и не переименовывайте ни его, ни репозиторий.

</details>

## О Хекслете

[Хекслет](https://ru.hexlet.io/) — школа программирования: авторские программы обучения с практикой, поддержкой наставников и реальными проектами, которые остаются в резюме. Этот репозиторий — один из таких проектов.
