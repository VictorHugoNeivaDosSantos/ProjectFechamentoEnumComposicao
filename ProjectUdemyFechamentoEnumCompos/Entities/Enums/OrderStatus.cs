using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUdemyFechamentoEnumCompos.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    };
}
