from django.views.generic import *

from generic_music_app.models import *


class SongListView(ListView):
    model = Song
    template_name = 'generic_music_app/templates/generic_music_app/list.html'


class SongDetailView(DetailView):
    model = Song
    template_name = 'generic_music_app/templates/generic_music_app/details.html'


class SongCreateView(CreateView):
    model = Song
    fields = '__all__'
    template_name = 'generic_music_app/templates/generic_music_app/form.html'
    success_url = '/music/'


class SongUpdateView(UpdateView):
    model = Song
    fields = '__all__'
    template_name = 'generic_music_app/templates/generic_music_app/form.html'
    success_url = '/music/'


class SongDeleteView(DeleteView):
    model = Song
    template_name = 'generic_music_app/templates/generic_music_app/del.html'
    success_url = '/music/'


##-----------------------------------------------------

class ArtistListView(ListView):
    song = Song
    model = Artist
    template_name = 'generic_music_app/templates/generic_music_app/artists.html'


class ArtistDetailView(DetailView):
    model = Artist
    template_name = 'generic_music_app/templates/generic_music_app/details.html'


class ArtistCreateView(CreateView):
    model = Artist
    fields = '__all__'
    template_name = 'generic_music_app/templates/generic_music_app/form.html'
    success_url = '/music/'


class ArtistUpdateView(UpdateView):
    model = Artist
    fields = '__all__'
    template_name = 'generic_music_app/templates/generic_music_app/form.html'
    success_url = '/music/'


class ArtistDeleteView(DeleteView):
    model = Artist
    template_name = 'generic_music_app/templates/generic_music_app/del.html'
    success_url = '/music/'