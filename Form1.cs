using System.Runtime.InteropServices;

namespace CardCounter
{
    public partial class Form1 : Form
    {
        CardManager cardManager = new CardManager(1);
        public Form1()
        {
            InitializeComponent();
            populateCombo();
            loadPictures();

        }
        private void populateCombo()
        {
            for (int i = 0; i < 9; i++)
                cardNumberCombo.Items.Add((i + 2));
            cardNumberCombo.Items.Add("J");
            cardNumberCombo.Items.Add("Q");
            cardNumberCombo.Items.Add("K");
            cardNumberCombo.Items.Add("A");
            cardTypeCombo.Items.Add("pik");
            cardTypeCombo.Items.Add("kier");
            cardTypeCombo.Items.Add("karo");
            cardTypeCombo.Items.Add("trefl");
        }
        private void loadPictures()
        {
            try
            {
                pikBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pikBox.ImageLocation = @"pik.png";
                treflBox.SizeMode = PictureBoxSizeMode.StretchImage;
                treflBox.ImageLocation = @"trefl.png";
                karoBox.SizeMode = PictureBoxSizeMode.StretchImage;
                karoBox.ImageLocation = @"karo.png";
                kierBox.SizeMode = PictureBoxSizeMode.StretchImage;
                kierBox.ImageLocation = @"kier.png";
            }catch(Exception ex)
            {

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirmCardButton_Click(object sender, EventArgs e)
        {
            if (cardNumberCombo.SelectedItem != null && cardTypeCombo.SelectedItem != null)
            {
                int number = CardManager.getNumberFromString(cardNumberCombo.SelectedItem.ToString());
                string type = cardTypeCombo.SelectedItem.ToString();
                Card card = cardManager.getCard(number, type);
                if (card != null)
                {
                    cardManager.getCards().Remove(card);
                    cardManager.getStack().Push(card);
                    cardManager.putCardTracking((number - 2) * 4 + CardManager.getNumberFromType(type));

                    if (card.getNumber() > 9)
                        cardManager.changeCardCount(-1);
                    else if (card.getNumber() < 7)
                        cardManager.changeCardCount(1);



                }

                updateEverything();
            }

        }

        private void updateEverything()
        {
            //update total cards left
            cardsInDeckLabel.Text = cardManager.getCards().Count.ToString();
            //update cards count
            cardCounterLabel.Text = (cardManager.getCardCount() / cardManager.getDecksNumber()).ToString();
            //update colors chances
            updateColorsChances();
            //update palyers chances
            updatePlayersChances();
            //update last seen card
            updateLastSeenCard();
        }
        private void updateColorsChances()
        {
            int treflSum = 0, pikSum = 0, karoSum = 0, kierSum = 0;
            List<Card> cards = cardManager.getCards();
            foreach (Card card in cards)
            {
                if (card.getType().Equals("trefl"))
                    treflSum++;
                else if (card.getType().Equals("pik"))
                    pikSum++;
                else if (card.getType().Equals("karo"))
                    karoSum++;
                else
                    kierSum++;
            }
            treflChanceLabel.Text = ((float)treflSum / cards.Count * 100).ToString("n2") + "%";
            pikChanceLabel.Text = ((float)pikSum / cards.Count * 100).ToString("n2") + "%";
            karoChanceLabel.Text = ((float)karoSum / cards.Count * 100).ToString("n2") + "%";
            kierChanceLabel.Text = ((float)kierSum / cards.Count * 100).ToString("n2") + "%";
            blackChanceLabel.Text = ((float)(treflSum + pikSum) / cards.Count * 100).ToString("n2") + "%";
            redChanceLabel.Text = ((float)(kierSum + karoSum) / cards.Count * 100).ToString("n2") + "%";
        }

        private void updatePlayersChances()
        {
            if (cardManager.getStack().Count % 2 == 0)
            {
                krupierChanceLabel.Text = "-";
                graczChanceLabel.Text = "-";
                wojnaChanceLabel.Text = "-";
                return;
            }
            Card card = cardManager.getStack().Peek();
            List<Card> cards = cardManager.getCards();
            int winSum = 0, loseSum = 0, drawSum = 0;
            foreach (Card card1 in cards)
            {
                if (card.getNumber() == card1.getNumber())
                {
                    drawSum++;
                }
                else if (card.getNumber() > card1.getNumber())
                {
                    winSum++;
                }
                else
                {
                    loseSum++;
                }
            }
            krupierChanceLabel.Text = ((float)loseSum / cards.Count * 100).ToString("n2") + "%";
            graczChanceLabel.Text = ((float)winSum / cards.Count * 100).ToString("n2") + "%";
            wojnaChanceLabel.Text = ((float)drawSum / cards.Count * 100).ToString("n2") + "%";


        }
        private void updateLastSeenCard()
        {
            string number;
            string type;
            string scount = "";
            int count;
            if (cardManager.getStack().Count > 0)
            {
                number = CardManager.getStringFromNumber(cardManager.getStack().Peek().getNumber());
                type = cardManager.getStack().Peek().getType();
                count = cardManager.getCardTracking((CardManager.getNumberFromString(number) - 2) * 4 + CardManager.getNumberFromType(type));
                if (count > 1)
                    scount = " (" + count + ")";
            }
            else
            {
                number = "Talia";
                type = "pe³na";
            }
            lastCardLabel.Text = number + " " + type + scount;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastCardLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void revertCardButton_Click(object sender, EventArgs e)
        {
            if (cardManager.getStack().Count == 0)
                return;
            Card card = cardManager.getStack().Pop();
            cardManager.getCards().Add(card);
            cardManager.popCardTracking((card.getNumber() - 2) * 4 + CardManager.getNumberFromType(card.getType()));
            if (card.getNumber() > 9)
                cardManager.changeCardCount(1);
            else if (card.getNumber() < 7)
                cardManager.changeCardCount(-1);
            updateEverything();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                cardManager = new CardManager(int.Parse(decksNumberBox.Text));
                updateEverything();

            }
            catch (Exception ex)
            {

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void blackChanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void redChanceLabel_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}