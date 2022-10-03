# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.

'''colors = ['red', 'green', 'red', 'blue', 'green', 'red', 'orange', 'red']
dictColors = {}

for i in colors:
    if i not in dictColors:
        dictColors[i] = 1
    else:
        dictColors[i] += 1
print(dictColors)
print(set(colors))'''

"""names = ['Ala', 'Ela', 'Ola', 'Iwona', 'Ilona', 'Adam', 'Robert', 'Małgorzata', 'Dagmara']
sex = {'male': [], 'female': []}
for i in names:
    if i.endswith('a'):
        sex['female'].append(i)
    else:
        sex['male'].append(i)
print(sex)"""

"""names = ['Ala', 'Ela', 'Ola', 'Iwona', 'Ilona', 'Adam', 'Robert', 'Małgorzata', 'Dagmara']
names_len = {}

for i in names:
    if len(i) in names_len:
        names_len[len(i)] += [i]
    else:
        names_len[len(i)] = [i]
print(names_len)"""

urlpatterns ={
    path('admin/', admin.site.urls),
}
