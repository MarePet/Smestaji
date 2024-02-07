using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class CommunicationHelper
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public CommunicationHelper(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public void Send<T>(T obj) where T : class
        {
            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (IOException)
            {
                MessageBox.Show("Server nije pokrenut!");
                return;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }
       
        public T Recieve<T>() where T : class
        {
            try
            {
                return (T)formatter.Deserialize(stream);
            }
            catch (IOException)
            {
                return null;
            }
        }
    }
}
