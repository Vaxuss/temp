class A:
    def __int__(self):
        print('a')

class B:
    def __int__(self):
        print('b')

class C(A,B):
    def __int__(self):
        print('C')
        super().__int__()

c = C()
