# Правила найменування гілок

Для найменування гілок ми дотримуємося наступних конвенцій:

- Кожна гілка повинна мати префікс, який вказує на тип гілки: feature/, bugfix/, hotfix/ тощо.
- Кожна гілка повинна мати ідентифікатор задачі з нашої системи відстеження проблем, наприклад feature/#5.
- Кожна гілка повинна мати короткий опис завдання, яке вона виконує, наприклад allow-users-to-do-smart-stuff.
- Частини назви гілки повинні бути розділені дефісами.
- Назва гілки повинна складатися лише з маленьких латинських літер (a-z) та цифр (0-9). Уникайте пробілів, пунктуації, символів підкреслення або будь-яких неалфавітно-цифрових символів.
- Не використовуйте простих чисел або шестнадцяткових чисел як частин назви гілки, оскільки git може сприймати їх як частину sha-1.

Приклад правильної назви гілки:

feature/#5-allow-users-to-do-smart-stuff

Приклади неправильних назв гілок:

feature_#1234_allow_users_to_do_smart_stuff (використовує символи підкреслення замість дефісів)
feature/1234 (використовує просте число замість ідентифікатора задачі)
feature/#1234/Allow Users to Do Smart Stuff (використовує великі літери та пробіли замість маленьких літер та дефісів)


# Branch naming rules

We follow the following conventions for naming branches:

- Each branch must have a prefix that indicates the type of branch: feature/, bugfix/, hotfix/, etc.
- Each branch should have a feature ID from our issue tracking system, for example feature/#5.
- Each branch should have a short description of the task it performs, for example allow-users-to-do-smart-stuff.
- Parts of the branch name must be separated by hyphens.
- The name of the branch should consist only of small Latin letters (a-z) and numbers (0-9). Avoid spaces, punctuation, underscores, or any non-alphanumeric characters.
- Don't use prime numbers or hex numbers as part of the branch name, because git might see them as part of sha-1.

Example of a correct branch name:

feature/#5-allow-users-to-do-smart-stuff

Examples of incorrect branch names:

feature_#1234_allow_users_to_do_smart_stuff (uses underscores instead of hyphens)
feature/1234 (uses a simple number instead of a task ID)
feature/#1234/Allow Users to Do Smart Stuff (uses uppercase letters and spaces instead of lowercase letters and hyphens)