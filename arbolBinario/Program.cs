// Definición de la clase BinaryTree para representar un nodo de un árbol binario.
public class BinaryTree
{
    // Propiedades para almacenar el valor del nodo, y los subárboles izquierdo y derecho.
    public int Value { get; set; }
    public BinaryTree Left { get; set; }
    public BinaryTree Right { get; set; }

    // Constructor que inicializa un nodo con un valor dado y sin subárboles.
    public BinaryTree(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }

    // Método estático para insertar un nuevo valor en el árbol binario.
    public static BinaryTree Insert(BinaryTree tree, int value)
    {
        // Si el árbol está vacío, crea un nuevo nodo con el valor dado.
        if (tree is null)
        {
            return new BinaryTree(value);
        }

        // Si el valor es menor que el valor del nodo actual, inserta en el subárbol izquierdo.
        if (value < tree.Value)
        {
            tree.Left = Insert(tree.Left, value);
        }
        // De lo contrario, inserta en el subárbol derecho.
        else
        {
            tree.Right = Insert(tree.Right, value);
        }

        // Devuelve el árbol con el nuevo valor insertado.
        return tree;
    }
}

class Program
{
    // Punto de entrada principal del programa.
    static void Main(string[] args)
    {
        // Crea el árbol binario con un nodo raíz y algunos nodos hijos.
        BinaryTree tree = new BinaryTree(10);
        tree.Left = new BinaryTree(5);
        tree.Right = new BinaryTree(15);
        tree.Left.Left = new BinaryTree(2);
        tree.Left.Right = new BinaryTree(7);

        // Inserta nuevos valores en el árbol.
        tree = BinaryTree.Insert(tree, 8);
        tree = BinaryTree.Insert(tree, 100);
        tree = BinaryTree.Insert(tree, 55);
        tree = BinaryTree.Insert(tree, 24);

        // Imprime los valores del árbol en orden.
        PrintInOrder(tree);
    }

    // Método para imprimir los valores del árbol en orden (in-order traversal).
    static void PrintInOrder(BinaryTree tree)
    {
        // Si el nodo actual no es nulo, procesa el subárbol izquierdo, imprime el valor del nodo,
        // y luego procesa el subárbol derecho.
        if (tree is not null)
        {
            PrintInOrder(tree.Left);   // Procesa el subárbol izquierdo.
            Console.WriteLine(tree.Value);  // Imprime el valor del nodo.
            PrintInOrder(tree.Right);  // Procesa el subárbol derecho.
        }
    }
}
