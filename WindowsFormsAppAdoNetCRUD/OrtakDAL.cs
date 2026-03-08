using System.Data;//veritabanı işlemleri için gerekli kütüphane
using System.Data.SqlClient;// sql işlemleri için ado.net kütüphanesi

namespace WindowsFormsAppAdoNetCRUD
{
    internal class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=WindowsFormsAppAdoNetCRUD; Integrated Security=True;"); // veritabanının bulunduğu server bilgisini connection string olarak burada tanımlıyoruz.
        internal void ConnectionKontrol()
        {
            if (_connection.State != ConnectionState.Open) //eğer veritabanı bağlantınızın durumu kapalı ise
                _connection.Open(); // veritabanı bağlantıosını aç
        }
        public DataTable GetDataTable(string sqlSorgu)
        {
            var dt = new DataTable();// geri döndürülecek data table nesnesi

            ConnectionKontrol(); // veritabanı bağlantısı kapalıysa açacak olan metod

            var command = new SqlCommand(sqlSorgu, _connection);//serverda sql sorgusu çalıştıracak nesne

            SqlDataReader reader = command.ExecuteReader(); // sql komutunu çalıştır ve dönen datayı reader nesnesine aktar

            dt.Load(reader); // reader içindeki verileri data table nesnesine yükle

            reader.Close(); //reader kapar
            _connection.Close();//_connection
            command.Dispose();//komutu yoket

            return dt;// db den okunan verileri gönder
        }
     
    }
}
