from django.shortcuts import render, redirect
from django.http import HttpResponse
from django.views import View
import random as rand
from . import fake_data

class FormView(View):
    def get(self, request):
        return HttpResponse('jesteśmy w metodzie GET')
    def post(self, request):
        return HttpResponse('jesteśmy w POST')

class PizzaView(View):
    def get(self, request):
        return render(request, 'FirstApp/pizza.html')
    def post(self, request):
        dodatki = request.POST.getlist('part', '')
        return HttpResponse(", ".join(dodatki))

class CarView(View):
    def get(self, request):
        return render(request, 'FirstApp/car.html')
    def post(self, request):
        wybor = request.POST.get('wybor', '')
        return HttpResponse(wybor)

class LoginView(View):
    def get(self, request):
        return render(request, 'FirstApp/login_class.html')
    def post(self, request):
        if request.POST.get('login', '') == 'admin' and request.POST.get('pass', '') == 'Tajne123':
            return HttpResponse("Witaj Admin!", "Brak Parametru")
        else:
            return redirect('/login/?message="zly login lub haslo"')




def hello(request):
    return HttpResponse('Hello')

def hello_name(request):
    name = request.GET.get('name', 'nieznajomy')
    return HttpResponse('Witaj ' + name)

def add(request):
    dane1 = float(request.GET.get('dane1', 0))
    dane2 = float(request.GET.get('dane2', 0))
    wynik = dane1 + dane2
    return HttpResponse('Wynik: ' + str(wynik))

def multiply(request):
    n = int(request.GET.get('n', 1))
    i = 1
    j = 1
    wynik = '<table>'
    while i <= n:
        wynik += '<tr>'
        while j <= n:
            wynik += "<td align = center style = 'border: solid; border-width: 1px; background-color: lightgreen'>"
            wynik += str(j*i) + " "
            j += 1
            wynik += '</td>'
        wynik += "</tr>"
        j = 1
        i += 1
    wynik += '</table>'
    return HttpResponse(wynik)

def bros(request):
    names = []
    names = request.GET.getlist("names", "brak")
    wynik = '<style>p:nth-child(even) {color: olive}</style>'
    for i in names:
        wynik += '<p size = 10px>'
        wynik += i
        wynik += '</p>'
    return HttpResponse(wynik)

def fibb(req):
    n = int(req.GET.get('n', 1))
    fib = [0, 1]
    wynik = '<ol>'
    if n > 1:
        for i in range(0, n-2):
            fib.append(fib[i]+fib[i+1])
    elif n == 1:
        fib = 1
    else:
        fib = 0
    for i in range(0, len(fib)):
        wynik += '<li>'
        wynik += str(fib[i])
        wynik += '</li>'
    wynik += '</ol>'
    return HttpResponse(str(wynik))

num = rand.randint(1, 100)

def game(req):
    message = '<form><input name=guess placeholder="podaj liczbę(1-100)"></form>'
    try:
        guess = int(req.GET.get('guess'))
        if(guess < num):
            message = '<form><input name=guess placeholder="podaj liczbę(1-100)"></form>'
            message += "twoja liczba jest za mała"
            return HttpResponse(str(message))
        elif(guess > num):
            message = '<form><input name=guess placeholder="podaj liczbę(1-100)"></form>'
            message += "twoja liczba jest za duża"
            return HttpResponse(str(message))
        elif(guess == num):
            message = '<form><input name=guess placeholder="podaj liczbę(1-100)"></form>'
            message += "zgadłeś"
            return HttpResponse(str(message))
        else:
            return HttpResponse(str(message))
    except:
        return HttpResponse(str(message))

def hellopath(req, name):
    return HttpResponse(name)

def article(req, id):
    message = ""
    if id < 4:
        message = 'artykul' + str(id)
    if id > 3:
        message = "brak artykułu"
    if id == 1:
        message += ' pierwszy artykuł'
    return HttpResponse(message)

def greetings(req, name, repeat):
    message = ""
    for i in range (0, repeat):
        message += 'Witaj ' + name + " "
    return HttpResponse(message)

def calc(req, number_a, operation, number_b):
    wynik = ""
    if number_a == 0 or number_b == 0:
        wynik = 'błędne dane'
    else:
        if operation == 'plus':
            wynik = number_a + number_b
        elif operation == 'minus':
            wynik = number_a - number_b
        elif operation == 'multiply':
            wynik = number_a * number_b
        elif operation == 'divide':
            wynik = number_a / number_b
        else:
            wynik = 'nie mogę wykonać tej operacji'
    return HttpResponse(str(wynik))

def rand_gen(req, min, max, throw = 1):
    wynik = 0
    for i in range(0, throw):
        wynik += rand.randint(min, max)
    return HttpResponse(str(wynik))

def index(request):
    return render(request,
                  'FirstApp/index.html',
                  context={'message':'Wiadomość z szablonu',
                           'names':['jan', 'adam', 'ewa']})
def form(request):
    if request.method == 'GET':
        return render(request, 'FirstApp/form.html')
    if request.method == 'POST':
        return HttpResponse(request.POST.get('test', 'brak'))

def fizz_buzz(request, n):
    data = []
    for i in range(1, n+1):
        if(i%5==0 and i%3 == 0):
            data.append('FizzBuzz')
        elif(i%3 == 0):
            data.append('Fizz')
        elif(i%5 == 0):
            data.append('Buzz')
        else:
            data.append(str(i))
    return render(request, 'FirstApp/fizz_buzz.html', context={'data': data})

def multiply(request, n):
    return render(request, 'FirstApp/multiply.html', context={'elements': range(1,n+1)})

def rpg(request):
    wygrana = ""
    Php = []
    Ehp = []
    attackP= []
    attackE= []
    tura = 0
    pDefense = 6
    pAttack = 2
    eDefense = 2
    eAttack = 5
    Php.append(rand.randint(100, 200))
    Ehp.append(rand.randint(100, 500))

    while Ehp[tura] > 0 or Php[tura] > 0:
        attackP.append(rand.randint(1, 100))
        Ehp.append(Ehp[tura] - attackP[tura])
        attackE.append(rand.randint(10, 20))
        Php.append(Php[tura] - attackE[tura])
        tura += 1
    stats = ""
    i = 0
    for i in range(i, tura):
        stats += 'Turn: ' + str(i+1) + '<br>'
        stats += 'Player hp: ' + str(Php[i]) + '\n Player damage: ' + str(attackP[i]) + '\n'
        stats += 'Enemy hp: ' + str(Ehp[i]) + '\n Enemy damage: ' + str(attackE[i]) + '\n'

    if (Php[tura] > 0):
        wygrana += "NEXT LEVEL - you WIN"
    if (Ehp[tura] > 0):
        wygrana += "GAME OVER - you LOSE"
    return render(request, 'FirstApp/rpg_game.html', context = {'tura': range(1, tura+1), 'pDefense': pDefense,
                                                                'pAttack': pAttack, "eDefense": eDefense,
                                                                'eAttack': eAttack, 'wygrana': wygrana,
                                                                'stats': stats})

def list_comment(request):
    return render(request, 'FirstApp/fake_comments.html')

def main(request):
    return render(request, 'FirstApp/base.html')

def login_user(request, message="ok" ):
    if request.method == 'GET':
        return render(request, 'FirstApp/login.html')
    if request.method == 'POST':
        if request.POST.get('login', '') == 'Admin' and request.POST.get('pass', '') == 'Tajne123':
            return HttpResponse("Witaj Admin!", "Brak Parametru")
        else:
            return redirect('/login/?message="zly login lub haslo"')

products = {}

def add_product(request):
    if request.method == 'GET':
        return render(request, 'FirstApp/add_product_form.html')
    if request.method == 'POST':
        products[request.POST.get('product', '')] = request.POST.get('price', '')
        return redirect('/show_product')

def show_products(request):
    return render(request, 'FirstApp/show_product.html', context={'products': products})