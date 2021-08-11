while True:
    try:
        billetes100 = int(input("Billetes de 100: "))
        billetes50 = int(input("Billetes de 50: "))
        billetes20 = int(input("Billetes de 20: "))
        billetes10 = int(input("Billetes de 10: "))
        billetes5 = int(input("Billetes de 5: "))
        billetes1 = int(input("Billetes de 1: "))
        article = float(input("Valor del artículo a comprar: "))
        total = (billetes100*100) + (billetes50*50) + (billetes20*10) + (billetes10*10) + (billetes5*5) + billetes1
        if total >= article:
            print("Dinero suficiente para realizar la compra, su cambio es: ", total - article, " dólares")
        else:
            print("Dinero insuficiente para realizar la compra, le faltan: ", article - total, " dólares")
    except ValueError:
        print("Ingreso no válido, intente nuevamente")