using UnityEngine;
using UnityEngine.UI;

public class Rifle : Guns
{
    [Header("Automat")]
    //[SerializeField] int _numberofBullets;
    [SerializeField] Text _bulletText;
    //[SerializeField] PlayerArmory _armory;

    public override void Shot()
    {
        base.Shot();
        //_numberofBullets -= 1;
        //UpdateText();

       /* if (_numberofBullets <= 0)
        {
           // _armory.TakeGunByIndex(0);
        }*/
    }
    public override void Activate()
    {
        base.Activate();
        //UpdateText();
        //_bulletText.enabled = true;
    }
    public override void Deactivate()
    {
        base.Deactivate();
        //_bulletText.enabled = false;
    }

    /*private void UpdateText()
    {
        _bulletText.text = $"Bullets: {_numberofBullets.ToString()}";
    }*/

   /* public override void AddBullets(int numberOfBullets)
    {
        base.AddBullets(numberOfBullets);
        _numberofBullets += numberOfBullets;
        UpdateText();
        //_armory.TakeGunByIndex(1);
    }*/
}
