using UnityEngine;


public class Inventario : MonoBehaviour
{
	//Criando uma referência para um objeto do tipo "Item"
	private Item item;
	//Variavel que faz referencia as telas
	public GameObject Tela, Tela2;

	
	public void PegarEscudo()
	{
		//Instancia o "Escudo" 
		item = new Escudo("Escudo");
		//Chama a função da classe item 
		item.Examinar();
	}

	public void PegarEspada()
	{
		//Instancia a "Espada"
		item = new Espada("Selvagem ");
		//Chama a função da classe item
		item.Examinar();
	}

	public void PegarCura()
	{
		//Instancia a "Cura"
		item = new Cura("Cura");
		//Chama a função da classe item
		item.Examinar();
	}

	//Função que realiza a mudança de "painéis"
	public void MudarTela()
	{
		Tela.SetActive(false);
		Tela2.SetActive(true);
	}

	public void VocecomprouEspada()
	{
		Debug.Log("Você comprou a espada");
	}
}

