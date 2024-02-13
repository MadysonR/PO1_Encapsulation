namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new();
        public Form1()
        {
        InitializeComponent();
            joueur.PointsDevie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDevie = joueur.PointsDeVie * 3;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            lbl_pointsVieJoueur.Text = "vie du joueur : " + joueur.PointsDeVie.ToString();
            lbl_pointsVieDragon.Text = "vie du dragon : " + dragon.PointsDeVie. ToString();
            lbl_puissanceAttaqueJoueur.Text = "Attaque du joueur : " + joueur.PointsDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Attaque du dragon : " + dragon.PointsDePuissance.ToString();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            dragon.PointsDevie
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }
    }
}