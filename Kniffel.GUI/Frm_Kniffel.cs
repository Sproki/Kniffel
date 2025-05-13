namespace Kniffel.GUI;

public partial class Frm_Kniffel : Form
{
    // Wuerfel Daten
    int startX = 50;
    int startY = 50;
    int wuerfelWidth = 350;
    int wuerfelHeight = 350;
    
    // Gewürfelte Zahl
    Random r = new Random();
    int zahl = 6;
    
    public Frm_Kniffel()
    {
        InitializeComponent();
        
        ResizeRedraw = true;
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        Pen pen = new Pen(Color.Black);
        
        g.DrawRectangle(pen, startX, startY, wuerfelWidth, wuerfelHeight);
        
        Point[,] raster = new Point[3, 3];
        
        int augenBox = 100;
        int abstand = 25;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                int x = startX + col * (augenBox + abstand);
                int y = startY + row * (augenBox + abstand);
                raster[row, col] = new Point(x, y);
            }
        }
        
        int[] GetAugenPositionen(int zahl)
        {
            switch (zahl)
            {
                case 1: return new[] { 4 };
                case 2: return new[] { 0, 8 };
                case 3: return new[] { 0, 4, 8 };
                case 4: return new[] { 0, 2, 6, 8 };
                case 5: return new[] { 0, 2, 4, 6, 8 };
                case 6: return new[] { 0, 2, 3, 5, 6, 8 };
                default: return Array.Empty<int>();
            }
        }
        
        int[] aktivePunkte = GetAugenPositionen(zahl); // z. B. 5

        foreach (int index in aktivePunkte)
        {
            int row = index / 3;
            int col = index % 3;
            Point p = raster[row, col]; // vorher definiertes Koordinatenraster
            g.FillEllipse(Brushes.Black, p.X, p.Y, augenBox, augenBox);
        }
    }

    private void Frm_Kniffel_Click(object sender, EventArgs e)
    {
        zahl = r.Next(1, 6 + 1);
        this.Refresh();
    }
}