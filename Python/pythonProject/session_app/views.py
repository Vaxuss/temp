from django.http import HttpResponse
from django.shortcuts import render

def counter(requset):
    if 'counter' in requset.session:
        requset.session['counter'] += 1
    else:
        requset.session['counter'] = 1
    return HttpResponse(str(requset.session.get('counter')))