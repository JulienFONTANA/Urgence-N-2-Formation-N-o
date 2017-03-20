using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_2_Formation_Néo_Solution
{
    class Program
    {
        /* Au secours! L'identitée de nos dévelopeurs à été usurpée et des espions essayent
         * de nous infiltrer de l'intérieur! Prouvez que vous avez suivi la formation Néo 
         * et que vous n'êtes pas un espion! Voici une série d'exercice pour vous tester
         * et prouvez que vous ête l'un des notres!
         * 
         * Vous n'avez pas le droit de modifier le Main... A vous de remplir les fonctions
         * qui vous sont données!
        */

        static void Main(string[] args)
        {
            int resultatNumerique = 0;
            string resultatString = "";

            // Affichez le double d'un nombre
            resultatNumerique = Double(198);
            Console.WriteLine(resultatNumerique);
            //Resultat attendu : 396

            // Affichez en lettre la valeur d'un entier entre 0 et 9 inclus
            resultatString = IntEnString(3);
            Console.WriteLine(resultatString);
            //Resultat attendu : trois

            // Affichez les lettres majuscules de 'A' à 'Z' sur une ligne
            printMAJAlpha();
            //Resultat attendu : ABCDEFGHIJKLMNOPQRSTUVWXYZ

            // Affichez les lettres minuscules de 'z' à 'a' sur une ligne
            printRevAlpha();
            //Resultat attendu : zyxwvutsrqponmlkjihgfedcba

            // Affichez les lchiffres de 0 à 9 sur une ligne
            printDigit();
            //Resultat attendu : 0123456789
        }

        static int Double(int nbr)
        {
        }

        static string IntEnString(int nbr)
        {
        }

        /* TABLE ASCII
         * 
         * Voici la table ASCII (American Standard Code for Information Interchange)
         * C'est ce code qui permet d'afficher les caractères latins de base dans chaque
         * programme. Voici la iste complète de la table ASCII de base. La première
         * colonne représente la valeur du charactère, la seconde son expréssion
         * textuelle, et la troisième est une explication.
         * 
         * Exemples : 
         *      0   => NUL  => Null (rien)
         *      36  => $    => Le signe Dollar
         *      90  => Z    => Lettre latine capitale Z
         *      
         * Cette table est internationnalement connue par les développeurs. Ne l'apprenez
         * par coeur, ça ne servirait à rien! Elle va vous être utile pour cet exercice...
         * 
         * Pour transformer une valeur numérique en caractère imprimable, utilisez la synthaxe:
         *          Console.Write((char)unicode);
         * 
         * 0 	    NUL     Null(nul)
         * 1 	    SOH     Start of Heading(début d'en-tête)
         * 2 	    STX     Start of Text (début de texte)
         * 3 	    ETX     End of Text(fin de texte)
         * 4 	    EOT     End of Transmission(fin de transmission)
         * 5 	    ENQ     Enquiry(demande)
         * 6 	    ACK     Acknowledge(accusé de réception)
         * 7 	    BEL     Bell(sonnerie)
         * 8 	    BS      Backspace(espacement arrière)
         * 9 	    HT      Horizontal Tab(tabulation horizontale)
         * 10 	    LF      Line Feed(saut de ligne)
         * 11 	    VT      Vertical Tab(tabulation verticale)
         * 12 	    FF      Form Feed(saut de page)
         * 13 	    CR      Carriage Return(retour chariot/retour à la ligne)
         * 14 	    SO      Shift Out(code spécial)
         * 15 	    SI      Shift In(code standard)
         * 16 	    DLE     Data Link Escape(échappement en transmission)
         * 17 	    DC1     Device Control 1 à 4 (contrôle de périphérique)
         * 18 	    DC2
         * 19 	    DC3
         * 20 	    DC4
         * 21 	    NAK     Negative Acknowledge(accusé de réception négatif)
         * 22 	    SYN     Synchronous Idle(attente synchronisée)
         * 23 	    ETB     End of Transmission Block(fin de bloc de transmission)
         * 24 	    CAN     Cancel(annulation)
         * 25 	    EM      End of Medium(fin de support)
         * 26 	    SUB     Substitute(remplacement)
         * 27 	    ESC     Escape(échappement)
         * 28 	    FS      File Separator(séparateur de fichier)
         * 29 	    GS      Group Separator(séparateur de groupe)
         * 30 	    RS      Record Separator(séparateur d'enregistrement)
         * 31 	    US      Unit Separator (séparateur d'unité)
         * 32 	    SP      Space (espacement)
         * 33 	    ! 	    Point d'exclamation
         * 34 	    " 	    Guillemet
         * 35 	    # 	    Croisillon9
         * 36 	    $ 	    Dollar
         * 37 	    % 	    Pourcent
         * 38 	    & 	    Esperluette9
         * 39 	    ' 	    Apostrophe13
         * 40 	    ( 	    Parenthèse ouvrante
         * 41 	    ) 	    Parenthèse fermante
         * 42 	    * 	    Astérisque
         * 43 	    + 	    Plus
         * 44 	    , 	    Virgule
         * 45 	    - 	    Trait d'union, moins9
         * 46 	    . 	    Point
         * 47 	    / 	    Barre oblique
         * 48 	    0 	    Chiffre zéro
         * 49 	    1 	    Chiffre un
         * 50 	    2 	    Chiffre deux
         * 51 	    3 	    Chiffre trois
         * 52 	    4 	    Chiffre quatre
         * 53 	    5 	    Chiffre cinq
         * 54 	    6 	    Chiffre six
         * 55 	    7 	    Chiffre sept
         * 56 	    8 	    Chiffre huit
         * 57 	    9 	    Chiffre neuf
         * 58 	    : 	    Deux-points
         * 59 	    ; 	    Point-virgule
         * 60 	    < 	    Inférieur
         * 61 	    = 	    Égal
         * 62 	    > 	    Supérieur
         * 63 	    ? 	    Point d'interrogation
         * 64 	    @ 	    Arobase9
         * 65 	    A       Lettre latine capitale A
         * 66 	    B       Lettre latine capitale B
         * 67 	    C       Lettre latine capitale C
         * 68 	    D       Lettre latine capitale D
         * 69 	    E       Lettre latine capitale E
         * 70 	    F       Lettre latine capitale F
         * 71 	    G       Lettre latine capitale G
         * 72 	    H       Lettre latine capitale H
         * 73 	    I       Lettre latine capitale I
         * 74 	    J       Lettre latine capitale J
         * 75 	    K       Lettre latine capitale K
         * 76 	    L       Lettre latine capitale L
         * 77 	    M       Lettre latine capitale M
         * 78 	    N       Lettre latine capitale N
         * 79 	    O       Lettre latine capitale O
         * 80 	    P       Lettre latine capitale P
         * 81 	    Q       Lettre latine capitale Q
         * 82 	    R       Lettre latine capitale R
         * 83 	    S       Lettre latine capitale S
         * 84 	    T       Lettre latine capitale T
         * 85 	    U       Lettre latine capitale U
         * 86 	    V       Lettre latine capitale V
         * 87 	    W       Lettre latine capitale W
         * 88 	    X       Lettre latine capitale X
         * 89 	    Y       Lettre latine capitale Y
         * 90 	    Z       Lettre latine capitale Z
         * 91 	    [       Crochet ouvrant
         * 92 	    \ 	    Barre oblique inversée
         * 93 	    ]       Crochet fermant
         * 94 	    ^ 	    Accent circonflexe(avec chasse)
         * 95 	    _       Tiret bas9
         * 96 	    ` 	    Accent grave(avec chasse)14
         * 97 	    a       Lettre latine minuscule a
         * 98 	    b       Lettre latine minuscule b
         * 99 	    c       Lettre latine minuscule c
         * 100      d       Lettre latine minuscule d
         * 101      e       Lettre latine minuscule e
         * 102      f       Lettre latine minuscule f
         * 103      g       Lettre latine minuscule g
         * 104      h       Lettre latine minuscule h
         * 105      i       Lettre latine minuscule i
         * 106      j       Lettre latine minuscule j
         * 107      k       Lettre latine minuscule k
         * 108      l       Lettre latine minuscule l
         * 109      m       Lettre latine minuscule m
         * 110      n       Lettre latine minuscule n
         * 111      o       Lettre latine minuscule o
         * 112      p       Lettre latine minuscule p
         * 113      q       Lettre latine minuscule q
         * 114      r       Lettre latine minuscule r
         * 115      s       Lettre latine minuscule s
         * 116      t       Lettre latine minuscule t
         * 117      u       Lettre latine minuscule u
         * 118      v       Lettre latine minuscule v
         * 119      w       Lettre latine minuscule w
         * 120      x       Lettre latine minuscule x
         * 121      y       Lettre latine minuscule y
         * 122      z       Lettre latine minuscule z
         * 123      { 	    Accolade ouvrante
         * 124      | 	    Barre verticale
         * 125      }       Accolade fermante
         * 126      ~       Tilde
         * 127      DEL     Delete(effacement)
        */

        static void printMAJAlpha()
        {
        }

        static void printRevAlpha()
        {
        }

        static void printDigit()
        {
        }
    }
}
