def conversor():   
    print("Conversor de Temperatura")
    print("------------------------")

    temperatura = input("Escolha C para Celcius e F para Farenheint: ")


    if temperatura.lower() == "c":
        t_c = int(input("Digite a temperatura em Celcius: "))
        print(round((t_c * 9/5) + 32, 2))
    elif temperatura.lower() == "f":
        t_f = int(input("Digite a temperatura em Farenheint: "))
        print(round((t_f - 32) *5/9, 2))
    else:
        print("Opção invalida. Escolha entre C ou F.")

if __name__ == "__main__":
    conversor()