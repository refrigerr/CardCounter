namespace CardCounter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            newGameButton = new Button();
            decksNumberBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            confirmCardButton = new Button();
            cardTypeCombo = new ComboBox();
            label4 = new Label();
            cardNumberCombo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            revertCardButton = new Button();
            lastCardLabel = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            karoBox = new PictureBox();
            kierBox = new PictureBox();
            treflBox = new PictureBox();
            pikBox = new PictureBox();
            wojnaChanceLabel = new Label();
            graczChanceLabel = new Label();
            krupierChanceLabel = new Label();
            label17 = new Label();
            label10 = new Label();
            label16 = new Label();
            redChanceLabel = new Label();
            blackChanceLabel = new Label();
            label21 = new Label();
            label20 = new Label();
            karoChanceLabel = new Label();
            kierChanceLabel = new Label();
            treflChanceLabel = new Label();
            pikChanceLabel = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            cardCounterLabel = new Label();
            label11 = new Label();
            label8 = new Label();
            cardCountLabel = new Label();
            label7 = new Label();
            panel5 = new Panel();
            cardsInDeckLabel = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)karoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kierBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treflBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pikBox).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(newGameButton);
            panel1.Controls.Add(decksNumberBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 52);
            panel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(188, 8);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(84, 30);
            newGameButton.TabIndex = 3;
            newGameButton.Text = "Nowa gra";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // decksNumberBox
            // 
            decksNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            decksNumberBox.Location = new Point(152, 8);
            decksNumberBox.Name = "decksNumberBox";
            decksNumberBox.Size = new Size(29, 29);
            decksNumberBox.TabIndex = 2;
            decksNumberBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 1;
            label1.Text = "Podaj liczbe talii:";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(confirmCardButton);
            panel2.Controls.Add(cardTypeCombo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cardNumberCombo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 117);
            panel2.TabIndex = 1;
            // 
            // confirmCardButton
            // 
            confirmCardButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmCardButton.Location = new Point(126, 87);
            confirmCardButton.Name = "confirmCardButton";
            confirmCardButton.Size = new Size(92, 29);
            confirmCardButton.TabIndex = 5;
            confirmCardButton.Text = "Zatwierdź";
            confirmCardButton.UseVisualStyleBackColor = true;
            confirmCardButton.Click += confirmCardButton_Click;
            // 
            // cardTypeCombo
            // 
            cardTypeCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cardTypeCombo.FormattingEnabled = true;
            cardTypeCombo.Location = new Point(255, 51);
            cardTypeCombo.Name = "cardTypeCombo";
            cardTypeCombo.Size = new Size(70, 29);
            cardTypeCombo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(163, 46);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 3;
            label4.Text = "Typ karty:";
            // 
            // cardNumberCombo
            // 
            cardNumberCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cardNumberCombo.FormattingEnabled = true;
            cardNumberCombo.Location = new Point(126, 51);
            cardNumberCombo.Name = "cardNumberCombo";
            cardNumberCombo.Size = new Size(40, 29);
            cardNumberCombo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 46);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 1;
            label3.Text = "Numer karty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 9);
            label2.Name = "label2";
            label2.Size = new Size(290, 28);
            label2.TabIndex = 0;
            label2.Text = "Podaj ostatnio zobaczoną kartę:";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(revertCardButton);
            panel3.Controls.Add(lastCardLabel);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(349, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 117);
            panel3.TabIndex = 2;
            // 
            // revertCardButton
            // 
            revertCardButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            revertCardButton.Location = new Point(22, 77);
            revertCardButton.Name = "revertCardButton";
            revertCardButton.Size = new Size(228, 35);
            revertCardButton.TabIndex = 6;
            revertCardButton.Text = "Cofnij ostatnie wprowadzenie";
            revertCardButton.UseVisualStyleBackColor = true;
            revertCardButton.Click += revertCardButton_Click;
            // 
            // lastCardLabel
            // 
            lastCardLabel.AutoSize = true;
            lastCardLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lastCardLabel.ForeColor = Color.White;
            lastCardLabel.Location = new Point(77, 37);
            lastCardLabel.Name = "lastCardLabel";
            lastCardLabel.Size = new Size(114, 28);
            lastCardLabel.TabIndex = 7;
            lastCardLabel.Text = "Talia pełna";
            lastCardLabel.Click += lastCardLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(268, 28);
            label5.TabIndex = 6;
            label5.Text = "Ostatnio wprowadzona karta:";
            label5.Click += label5_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(cardCountLabel);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(13, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(604, 358);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(cardCounterLabel);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(604, 358);
            panel6.TabIndex = 8;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(karoBox);
            panel7.Controls.Add(kierBox);
            panel7.Controls.Add(treflBox);
            panel7.Controls.Add(pikBox);
            panel7.Controls.Add(wojnaChanceLabel);
            panel7.Controls.Add(graczChanceLabel);
            panel7.Controls.Add(krupierChanceLabel);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(redChanceLabel);
            panel7.Controls.Add(blackChanceLabel);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(karoChanceLabel);
            panel7.Controls.Add(kierChanceLabel);
            panel7.Controls.Add(treflChanceLabel);
            panel7.Controls.Add(pikChanceLabel);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(6, 35);
            panel7.Name = "panel7";
            panel7.Size = new Size(211, 318);
            panel7.TabIndex = 8;
            // 
            // karoBox
            // 
            karoBox.ImageLocation = "";
            karoBox.Location = new Point(26, 122);
            karoBox.Name = "karoBox";
            karoBox.Size = new Size(25, 27);
            karoBox.TabIndex = 30;
            karoBox.TabStop = false;
            // 
            // kierBox
            // 
            kierBox.ImageLocation = "";
            kierBox.Location = new Point(33, 96);
            kierBox.Name = "kierBox";
            kierBox.Size = new Size(25, 27);
            kierBox.TabIndex = 29;
            kierBox.TabStop = false;
            // 
            // treflBox
            // 
            treflBox.ImageLocation = "";
            treflBox.Location = new Point(33, 66);
            treflBox.Name = "treflBox";
            treflBox.Size = new Size(25, 27);
            treflBox.TabIndex = 28;
            treflBox.TabStop = false;
            // 
            // pikBox
            // 
            pikBox.Image = Properties.Resources.pik;
            pikBox.ImageLocation = "";
            pikBox.Location = new Point(41, 38);
            pikBox.Name = "pikBox";
            pikBox.Size = new Size(25, 27);
            pikBox.TabIndex = 27;
            pikBox.TabStop = false;
            // 
            // wojnaChanceLabel
            // 
            wojnaChanceLabel.AutoSize = true;
            wojnaChanceLabel.BackColor = Color.Transparent;
            wojnaChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            wojnaChanceLabel.ForeColor = Color.White;
            wojnaChanceLabel.Location = new Point(101, 283);
            wojnaChanceLabel.Name = "wojnaChanceLabel";
            wojnaChanceLabel.Size = new Size(80, 28);
            wojnaChanceLabel.TabIndex = 26;
            wojnaChanceLabel.Text = "number";
            // 
            // graczChanceLabel
            // 
            graczChanceLabel.AutoSize = true;
            graczChanceLabel.BackColor = Color.Transparent;
            graczChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            graczChanceLabel.ForeColor = Color.White;
            graczChanceLabel.Location = new Point(101, 255);
            graczChanceLabel.Name = "graczChanceLabel";
            graczChanceLabel.Size = new Size(80, 28);
            graczChanceLabel.TabIndex = 25;
            graczChanceLabel.Text = "number";
            // 
            // krupierChanceLabel
            // 
            krupierChanceLabel.AutoSize = true;
            krupierChanceLabel.BackColor = Color.Transparent;
            krupierChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            krupierChanceLabel.ForeColor = Color.White;
            krupierChanceLabel.Location = new Point(101, 227);
            krupierChanceLabel.Name = "krupierChanceLabel";
            krupierChanceLabel.Size = new Size(80, 28);
            krupierChanceLabel.TabIndex = 24;
            krupierChanceLabel.Text = "number";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(33, 283);
            label17.Name = "label17";
            label17.Size = new Size(72, 28);
            label17.TabIndex = 23;
            label17.Text = "Wojna:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(41, 255);
            label10.Name = "label10";
            label10.Size = new Size(65, 28);
            label10.TabIndex = 22;
            label10.Text = "Gracz:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(26, 227);
            label16.Name = "label16";
            label16.Size = new Size(80, 28);
            label16.TabIndex = 21;
            label16.Text = "Krupier:";
            // 
            // redChanceLabel
            // 
            redChanceLabel.AutoSize = true;
            redChanceLabel.BackColor = Color.Transparent;
            redChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            redChanceLabel.ForeColor = Color.White;
            redChanceLabel.Location = new Point(99, 188);
            redChanceLabel.Name = "redChanceLabel";
            redChanceLabel.Size = new Size(80, 28);
            redChanceLabel.TabIndex = 20;
            redChanceLabel.Text = "number";
            redChanceLabel.Click += redChanceLabel_Click;
            // 
            // blackChanceLabel
            // 
            blackChanceLabel.AutoSize = true;
            blackChanceLabel.BackColor = Color.Transparent;
            blackChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            blackChanceLabel.ForeColor = Color.White;
            blackChanceLabel.Location = new Point(99, 160);
            blackChanceLabel.Name = "blackChanceLabel";
            blackChanceLabel.Size = new Size(80, 28);
            blackChanceLabel.TabIndex = 19;
            blackChanceLabel.Text = "number";
            blackChanceLabel.Click += blackChanceLabel_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(4, 188);
            label21.Name = "label21";
            label21.Size = new Size(101, 28);
            label21.TabIndex = 18;
            label21.Text = "Czerwony:";
            label21.Click += label21_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(30, 160);
            label20.Name = "label20";
            label20.Size = new Size(75, 28);
            label20.TabIndex = 17;
            label20.Text = "Czarny:";
            label20.Click += label20_Click;
            // 
            // karoChanceLabel
            // 
            karoChanceLabel.AutoSize = true;
            karoChanceLabel.BackColor = Color.Transparent;
            karoChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            karoChanceLabel.ForeColor = Color.White;
            karoChanceLabel.Location = new Point(101, 121);
            karoChanceLabel.Name = "karoChanceLabel";
            karoChanceLabel.Size = new Size(80, 28);
            karoChanceLabel.TabIndex = 16;
            karoChanceLabel.Text = "number";
            // 
            // kierChanceLabel
            // 
            kierChanceLabel.AutoSize = true;
            kierChanceLabel.BackColor = Color.Transparent;
            kierChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kierChanceLabel.ForeColor = Color.White;
            kierChanceLabel.Location = new Point(101, 93);
            kierChanceLabel.Name = "kierChanceLabel";
            kierChanceLabel.Size = new Size(80, 28);
            kierChanceLabel.TabIndex = 15;
            kierChanceLabel.Text = "number";
            // 
            // treflChanceLabel
            // 
            treflChanceLabel.AutoSize = true;
            treflChanceLabel.BackColor = Color.Transparent;
            treflChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            treflChanceLabel.ForeColor = Color.White;
            treflChanceLabel.Location = new Point(101, 65);
            treflChanceLabel.Name = "treflChanceLabel";
            treflChanceLabel.Size = new Size(80, 28);
            treflChanceLabel.TabIndex = 14;
            treflChanceLabel.Text = "number";
            // 
            // pikChanceLabel
            // 
            pikChanceLabel.AutoSize = true;
            pikChanceLabel.BackColor = Color.Transparent;
            pikChanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pikChanceLabel.ForeColor = Color.White;
            pikChanceLabel.Location = new Point(101, 37);
            pikChanceLabel.Name = "pikChanceLabel";
            pikChanceLabel.Size = new Size(80, 28);
            pikChanceLabel.TabIndex = 13;
            pikChanceLabel.Text = "number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(49, 121);
            label15.Name = "label15";
            label15.Size = new Size(57, 28);
            label15.TabIndex = 12;
            label15.Text = "Karo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(56, 93);
            label14.Name = "label14";
            label14.Size = new Size(50, 28);
            label14.TabIndex = 11;
            label14.Text = "Kier:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(54, 65);
            label13.Name = "label13";
            label13.Size = new Size(52, 28);
            label13.TabIndex = 10;
            label13.Text = "Trefl:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(64, 37);
            label12.Name = "label12";
            label12.Size = new Size(42, 28);
            label12.TabIndex = 9;
            label12.Text = "Pik:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(48, 0);
            label9.Name = "label9";
            label9.Size = new Size(110, 28);
            label9.TabIndex = 7;
            label9.Text = "Szanse na:";
            label9.Click += label9_Click;
            // 
            // cardCounterLabel
            // 
            cardCounterLabel.AutoSize = true;
            cardCounterLabel.BackColor = Color.Transparent;
            cardCounterLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cardCounterLabel.ForeColor = Color.White;
            cardCounterLabel.Location = new Point(195, -1);
            cardCounterLabel.Name = "cardCounterLabel";
            cardCounterLabel.Size = new Size(80, 28);
            cardCounterLabel.TabIndex = 6;
            cardCounterLabel.Text = "number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(194, 28);
            label11.TabIndex = 6;
            label11.Text = "Wartość bieżąca talii:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(312, 35);
            label8.Name = "label8";
            label8.Size = new Size(194, 28);
            label8.TabIndex = 7;
            label8.Text = "Wartość bieżąca talii:";
            // 
            // cardCountLabel
            // 
            cardCountLabel.AutoSize = true;
            cardCountLabel.BackColor = Color.Transparent;
            cardCountLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cardCountLabel.ForeColor = Color.White;
            cardCountLabel.Location = new Point(191, 0);
            cardCountLabel.Name = "cardCountLabel";
            cardCountLabel.Size = new Size(80, 28);
            cardCountLabel.TabIndex = 6;
            cardCountLabel.Text = "number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 28);
            label7.TabIndex = 6;
            label7.Text = "Wartość bieżąca talii:";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(cardsInDeckLabel);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(295, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 52);
            panel5.TabIndex = 4;
            // 
            // cardsInDeckLabel
            // 
            cardsInDeckLabel.AutoSize = true;
            cardsInDeckLabel.BackColor = Color.Transparent;
            cardsInDeckLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cardsInDeckLabel.ForeColor = Color.White;
            cardsInDeckLabel.Location = new Point(245, 10);
            cardsInDeckLabel.Name = "cardsInDeckLabel";
            cardsInDeckLabel.Size = new Size(80, 28);
            cardsInDeckLabel.TabIndex = 5;
            cardsInDeckLabel.Text = "number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(249, 28);
            label6.TabIndex = 4;
            label6.Text = "Pozostała liczba kart w talii:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(629, 563);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)karoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kierBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)treflBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pikBox).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox decksNumberBox;
        private Button newGameButton;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private ComboBox cardNumberCombo;
        private Label label3;
        private ComboBox cardTypeCombo;
        private Button confirmCardButton;
        private Panel panel3;
        private Label label5;
        private Button revertCardButton;
        private Label lastCardLabel;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Label cardsInDeckLabel;
        private Label label7;
        private Label cardCountLabel;
        private Panel panel6;
        private Panel panel7;
        private Label label9;
        private Label cardCounterLabel;
        private Label label11;
        private Label label8;
        private Label label20;
        private Label karoChanceLabel;
        private Label kierChanceLabel;
        private Label treflChanceLabel;
        private Label pikChanceLabel;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label redChanceLabel;
        private Label blackChanceLabel;
        private Label label21;
        private Label label16;
        private Label wojnaChanceLabel;
        private Label graczChanceLabel;
        private Label krupierChanceLabel;
        private Label label17;
        private Label label10;
        private PictureBox pikBox;
        private PictureBox karoBox;
        private PictureBox kierBox;
        private PictureBox treflBox;
    }
}