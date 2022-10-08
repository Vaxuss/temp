from django.db import models

# Create your models here.

class Book(models.Model):
    title = models.CharField(max_length=256)
    author = models.CharField(max_length=512)
    description = models.CharField(max_length=512)
    page_count = models.IntegerField()

    def __str__(self):
        return f'{self.title} {self.author} { self.description } {self.page_count}'