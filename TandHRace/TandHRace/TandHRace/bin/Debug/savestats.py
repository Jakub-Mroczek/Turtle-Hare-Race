import sys

f = open("statistics.txt", "w+")
hareWins = sys.argv[0]
tortoiseWins = sys.argv[1]
draws = sys.argv[2]
total = int(hareWins) + int(tortoiseWins) + int(draws)
f.write("Hare" + " " + hareWins + "\r\n" + 
        "Tortoise" + " " + tortoiseWins + "\r\n" + 
        "Draws" + " " + draws + "\r\n" +
        "Total" + " " + str(total))
f.close()
