﻿namespace Ednevnik
{
    partial class Osoba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_adresa = new System.Windows.Forms.Label();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(135, 35);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 24);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(121, 71);
            this.lbl_ime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(46, 24);
            this.lbl_ime.TabIndex = 1;
            this.lbl_ime.Text = "Ime:";
            this.lbl_ime.Click += new System.EventHandler(this.lbl_ime_Click);
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(83, 107);
            this.lbl_prezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(84, 24);
            this.lbl_prezime.TabIndex = 2;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // lbl_adresa
            // 
            this.lbl_adresa.AutoSize = true;
            this.lbl_adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adresa.Location = new System.Drawing.Point(92, 146);
            this.lbl_adresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adresa.Name = "lbl_adresa";
            this.lbl_adresa.Size = new System.Drawing.Size(75, 24);
            this.lbl_adresa.TabIndex = 3;
            this.lbl_adresa.Text = "Adresa:";
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jmbg.Location = new System.Drawing.Point(101, 182);
            this.lbl_jmbg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(66, 24);
            this.lbl_jmbg.TabIndex = 4;
            this.lbl_jmbg.Text = "JMBG:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(37, 218);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(130, 24);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "E-mail adresa:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(88, 254);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(79, 24);
            this.lbl_pass.TabIndex = 6;
            this.lbl_pass.Text = "Lozinka:";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(103, 290);
            this.lbl_uloga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(64, 24);
            this.lbl_uloga.TabIndex = 7;
            this.lbl_uloga.Text = "Uloga:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(171, 30);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(83, 32);
            this.txt_id.TabIndex = 8;
            // 
            // txt_ime
            // 
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(171, 66);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(212, 32);
            this.txt_ime.TabIndex = 9;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(171, 102);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(212, 32);
            this.txt_prezime.TabIndex = 10;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresa.Location = new System.Drawing.Point(171, 141);
            this.txt_adresa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(212, 32);
            this.txt_adresa.TabIndex = 11;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jmbg.Location = new System.Drawing.Point(171, 177);
            this.txt_jmbg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(212, 32);
            this.txt_jmbg.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(171, 213);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 32);
            this.txt_email.TabIndex = 13;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(171, 249);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(212, 32);
            this.txt_pass.TabIndex = 14;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uloga.Location = new System.Drawing.Point(171, 285);
            this.txt_uloga.Margin = new System.Windows.Forms.Padding(2);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(212, 32);
            this.txt_uloga.TabIndex = 15;
            // 
            // btn_prvi
            // 
            this.btn_prvi.Location = new System.Drawing.Point(452, 124);
            this.btn_prvi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(91, 32);
            this.btn_prvi.TabIndex = 16;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Location = new System.Drawing.Point(598, 124);
            this.btn_prethodni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(72, 32);
            this.btn_prethodni.TabIndex = 17;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Location = new System.Drawing.Point(727, 124);
            this.btn_sledeci.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(72, 32);
            this.btn_sledeci.TabIndex = 18;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Location = new System.Drawing.Point(848, 124);
            this.btn_poslednji.Margin = new System.Windows.Forms.Padding(2);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(91, 32);
            this.btn_poslednji.TabIndex = 19;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(617, 194);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(53, 32);
            this.btn_dodaj.TabIndex = 20;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Location = new System.Drawing.Point(727, 194);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(53, 32);
            this.btn_izmeni.TabIndex = 21;
            this.btn_izmeni.Text = "Promeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(490, 194);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(53, 32);
            this.btn_obrisi.TabIndex = 22;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Location = new System.Drawing.Point(848, 194);
            this.btn_osvezi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(53, 32);
            this.btn_osvezi.TabIndex = 23;
            this.btn_osvezi.Text = "Refresh";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 390);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_adresa);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_adresa;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_uloga;
    }
}