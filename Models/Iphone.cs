namespace DesafioPOO.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Iphone : Smartphone
  {
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {

    }
    public string nomeApp { get; set; }
    public override void InstalarAplicativo(string nomeApp)
    {
      nomeApp = "mastondon";
    }
    // TODO: Sobrescrever o método "InstalarAplicativo"
  }
}
