from django.db import models

# Create your models here.
class Song(models.Model):
    title = models.CharField(max_length=256)
    artist = models.ManyToManyField('Artist')

    def __str__(self):
        return f"{self.title}"

class Artist(models.Model):
    name = models.CharField(max_length=128)
    surname = models.CharField(max_length=256)

    def __str__(self):
        return f"{self.name} {self.surname}"
