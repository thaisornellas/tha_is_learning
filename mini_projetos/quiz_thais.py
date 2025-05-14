def perguntas():
    print("############################")
    print("Quão bem vc conhece a Thais?")
    print("############################")
    nome = input("Qual seu nome? ")

    print("Ok {}, vamos lá!".format(nome))

    pais = ["brasil", "paraguai", "frança", "inglaterra", "bélgica", "itália", "holanda", "argentina"]

    acertos = []
    i = 0
    chances = len(pais)

    while len(acertos) < chances:
        chute = input("Em quais países a Thais já esteve? (Não se esqueça dos acentos) ")
        chute = chute.strip()
        if chute.lower() in pais:
            acertos.insert(i, chute)
            print(acertos)
            pais.remove(chute.lower())
            i = i + 1

        elif chute in acertos:
            print("Você já disse esse país, tente novamente.")

        else:
            print("Você errou, tente novamente.")
        

    print("Parabéns! Você acertou!")


    comidas = ["sushi", "strogonoff"]

    acertos_2 = []
    j = 0
    chances_2 = len(comidas)

    while len(acertos_2) < chances_2:
        chute_2 = input("O que Thais mais gosta de comer? ")
        chute_2 = chute_2.strip()
        if chute_2.lower() in comidas:
            acertos_2.insert(j, chute_2)
            print(acertos_2)
            comidas.remove(chute_2.lower())
            j = j + 1

        elif chute_2 in acertos_2:
            print("Você já disse essa comida, tente novamente.")

        else:
            print("Você errou, tente novamente.")

    print("Parabéns! Você acertou!")

    print("Quantos anos a Thais tem?")
    pergunta = input("a) 20 b) 25 c) 22 d) 24 ")

    if pergunta.lower() == "d":
        print("Muito bem! Você acertou!")
    else:
        print("Você errou! A resposta certa era letra d) 24 anos")

if __name__ == "__main__":
    perguntas()
