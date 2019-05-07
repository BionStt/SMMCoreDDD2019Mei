using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Extensions
{
    public class FinancialFunctional
    {

        /**
            * Emulates Excel/Calc's PMT(interest_rate, number_payments, PV, FV, Type)
            * function, which calculates the mortgage or annuity payment / yield per
            * period.
            * 
            * @param r
            *            - periodic interest rate represented as a decimal.
            * @param nper
            *            - number of total payments / periods.
            * @param pv
            *            - present value -- borrowed or invested principal.
            * @param fv
            *            - future value of loan or annuity.
            * @param type
            *            - when payment is made: beginning of period is 1; end, 0.
            * @return <code>double</code> representing periodic payment amount.
            */
        public static double Pmt(double r, int nper, double pv, double fv, int type)
        {

            // pmt = r / ((1 + r)^N - 1) * -(pv * (1 + r)^N + fv)
            double Pmt = r / (Math.Pow(1 + r, nper) - 1)
                    * -(pv * Math.Pow(1 + r, nper) + fv);

            // account for payments at beginning of period versus end.
            if (type == 1)
                Pmt /= (1 + r);

            // return results to caller.
            return Pmt;
        }

        /**
         * Overloaded pmt() call omitting type, which defaults to 0.
         * 
         * @see #pmt(double, int, double, double, int)
         */
        public static double Pmt(double r, int nper, double pv, double fv)
        {
            return Pmt(r, nper, pv, fv, 0);
        }

        /**
         * Overloaded pmt() call omitting fv and type, which both default to 0.
         * 
         * @see #pmt(double, int, double, double, int)
         */
        public static double Pmt(double r, int nper, double pv)
        {
            return Pmt(r, nper, pv, 0);
        }

        /**
         * Emulates Excel/Calc's FV(interest_rate, number_payments, payment, PV,
         * Type) function, which calculates future value or principal at period N.
         * 
         * @param r
         *            - periodic interest rate represented as a decimal.
         * @param nper
         *            - number of total payments / periods.
         * @param c
         *            - periodic payment amount.
         * @param pv
         *            - present value -- borrowed or invested principal.
         * @param type
         *            - when payment is made: beginning of period is 1; end, 0.
         * @return <code>double</code> representing future principal value.
         */
        public static double Fv(double r, int nper, double c, double pv, int type)
        {

            // account for payments at beginning of period versus end.
            // since we are going in reverse, we multiply by 1 plus interest rate.
            if (type == 1)
                c *= (1 + r);

            // fv = -(((1 + r)^N - 1) / r * c + pv * (1 + r)^N);
            double fv = -((Math.Pow(1 + r, nper) - 1) / r * c + pv
                    * Math.Pow(1 + r, nper));

            // return results to caller.
            return fv;
        }

        /**
         * Overloaded fv() call omitting type, which defaults to 0.
         * 
         * @see #fv(double, int, double, double, int)
         */
        public static double Fv(double r, int nper, double c, double pv)
        {
            return Fv(r, nper, c, pv);
        }

        /**
         * Emulates Excel/Calc's IPMT(interest_rate, period, number_payments, PV,
         * FV, Type) function, which calculates the portion of the payment at a
         * given period that is the interest on previous balance.
         * 
         * @param r
         *            - periodic interest rate represented as a decimal.
         * @param per
         *            - period (payment number) to check value at.
         * @param nper
         *            - number of total payments / periods.
         * @param pv
         *            - present value -- borrowed or invested principal.
         * @param fv
         *            - future value of loan or annuity.
         * @param type
         *            - when payment is made: beginning of period is 1; end, 0.
         * @return <code>double</code> representing interest portion of payment.
         * 
         * @see #pmt(double, int, double, double, int)
         * @see #fv(double, int, double, double, int)
         */
        public static double Ipmt(double r, int per, int nper, double pv,
                double fv, int type)
        {

            // Prior period (i.e., per-1) balance times periodic interest rate.
            // i.e., ipmt = fv(r, per-1, c, pv, type) * r
            // where c = pmt(r, nper, pv, fv, type)
            double Ipmt = Fv(r, per - 1, Pmt(r, nper, pv, fv, type), pv, type) * r;

            // account for payments at beginning of period versus end.
            if (type == 1)
                Ipmt /= (1 + r);

            // return results to caller.
            return Ipmt;
        }

        /**
         * Emulates Excel/Calc's PPMT(interest_rate, period, number_payments, PV,
         * FV, Type) function, which calculates the portion of the payment at a
         * given period that will apply to principal.
         * 
         * @param r
         *            - periodic interest rate represented as a decimal.
         * @param per
         *            - period (payment number) to check value at.
         * @param nper
         *            - number of total payments / periods.
         * @param pv
         *            - present value -- borrowed or invested principal.
         * @param fv
         *            - future value of loan or annuity.
         * @param type
         *            - when payment is made: beginning of period is 1; end, 0.
         * @return <code>double</code> representing principal portion of payment.
         * 
         * @see #pmt(double, int, double, double, int)
         * @see #ipmt(double, int, int, double, double, int)
         */
        public static double Ppmt(double r, int per, int nper, double pv,
                double fv, int type)
        {

            // Calculated payment per period minus interest portion of that period.
            // i.e., ppmt = c - i
            // where c = pmt(r, nper, pv, fv, type)
            // and i = ipmt(r, per, nper, pv, fv, type)
            return Pmt(r, nper, pv, fv, type) - Ipmt(r, per, nper, pv, fv, type);
        }

    }
}
