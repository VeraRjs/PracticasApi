namespace cooldos
{

    public class Articulo
    {
        public int Id { get; set; }

        public string nombreProducto { get; set; }

        public string descripcionProducto { get; set; }
        public Articulo(int id, string nombreProducto, string descripcion)
        {

            this.Id = id;
            this.nombreProducto = nombreProducto;
            this.descripcionProducto = descripcion;

        }

    }

}