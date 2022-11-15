using System;
using ML.Data.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML_Logica;

namespace ML.Logica
{
    public class ViajeServicio : IViajeServicio
    {
        private MLContext _context;

        public ViajeServicio(MLContext context)
        {
            _context = context;
        }

        public float predecirPrecio(ViajeModel viajeModel)
        {
            var sampleData = new MLPricePrediction.ModelInput()
            {
                Vendor_id = viajeModel.Vendor_id,
                Rate_code = viajeModel.Rate_code,
                Passenger_count = viajeModel.Passenger_count,
                Trip_distance = viajeModel.Trip_distance,
                Payment_type = viajeModel.Payment_type,
            };

            float result = MLPricePrediction.Predict(sampleData).Score;

            return result;
        }

    }
}
