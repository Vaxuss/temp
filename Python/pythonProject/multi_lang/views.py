from django.http import HttpResponse
from django.shortcuts import render
from django.utils.translation import gettext as _


def hello(request):
    message = _("Hello message to translate")
    return HttpResponse(message)