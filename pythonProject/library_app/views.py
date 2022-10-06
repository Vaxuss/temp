from django.shortcuts import render, redirect
from django.views import View

from library_app.forms import BookForm
from library_app.models import Book


# Create your views here.
class EditBookView(View):
    def get(self, request, n):
        form = BookForm(instance = Book.objects.get(pk=n))
        return render(request, 'library_app/book_form.html', {'form':form,
                                                             'message': "Edytuj Książke"})

    def post(self, request, n):
        form = BookForm(request.POST, instance=Book.objects.get(pk=n))
        if form.is_valid():
            form.save()
            return redirect("/lib/")
        else:
            return render(request, 'library_app/book_form.html', {'form': form,
                                                         'message': "Edytuj Książke"})


class AddBookView(View):
    def get(self, request):
        form = BookForm()
        return render(request, 'library_app/book_form.html',{'form':form,
                                                             'message': "Dodaj Książke"})

    def post(self, request):
        form = BookForm(request.POST, instance=Book())
        if form.is_valid():
            form.save()
            return redirect("/lib/")
        else:
            return render(request, 'library_app/book_form.html', {'form': form,
                                                         'message': "Dodaj Książke"})


def BookShow(request):
    form = Book.objects.all()
    return render(request, 'library_app/mian.html', {'form': form})