using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
	//Criando uma referência para um objeto do tipo "Item"
	private Item item;
	
	public void Analisar()
	{
		//instancia o escudo 
		item = new Escudo("Escudo");
		//examina o item
		item.Examinar();
	}

	public void PegarEspada()
	{
		item = new Espada("Excalibur");
		item.Examinar();
	}

	public void PegarCura()
	{
		item = new Cura("Cura");
		item.Examinar();
	}
}

