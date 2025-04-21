using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public abstract class Controller
    {
        private static Service _service = new Service();
        public static void add(String inputData) 
        {
            try
            {
                _service.checkData(inputData);
                _service.add(inputData);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void update(String inputData) 
        {
            try
            {
                _service.checkData(inputData);
                _service.update(inputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void remove(String name) 
        {
            try
            {

                _service.remove(name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
