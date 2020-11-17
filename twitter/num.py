

num = "7474938739"


def Base_10_to_n(num, n=7):
    if (int(num / n)):
        return Base_10_to_n(int(num / n), n) + str(num % n)
    return str(num % n)


num = Base_10_to_n(int(num))
print(num)
num = Base_10_to_n(int(num), 16)
print(num)
