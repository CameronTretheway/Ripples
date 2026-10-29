using MohawkGame2D;
using System;

public class Ripple
{
    


        int rippleExpand = 0;
    public Ripple()
    {


    }
    public void Setup()
    {



    }

    public void Update(int ripplePlacerX, int ripplePlacerY, int initialRippleSize)
    {

        ripple(ripplePlacerX, ripplePlacerY, initialRippleSize);
        rippleExpand = rippleExpand + 1;

    }

    void ripple(int rippleXPos, int rippleYPos, int rippleExpand)
    {

        rippleXPos = 0;
        rippleYPos = 0;


        Draw.SetFillColor(Color.Clear);
        Draw.SetLineColor(150, 150, 200);

        Draw.Circle(rippleXPos, rippleYPos, rippleExpand);

        rippleExpand = rippleExpand + 1;
    }
}
