using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Login
{
    public partial class GRADINGSHEET : Form
    {
        private String ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Hachi\Desktop\GAHUM CC103\gradingsheetproject.mdb;";
        public GRADINGSHEET()
        {
            InitializeComponent();

        }
        private void section()
        {
            if (TXTYEARLEVEL.Text == "1ST YEAR")
            {
                TXTSECTION.Items.Clear();
                TXTSECTION.Items.Add("1A");
                TXTSECTION.Items.Add("1B");
                TXTSECTION.Items.Add("1C");
                TXTSECTION.Items.Add("1D");
                TXTSECTION.Items.Add("1E");
                TXTSECTION.Items.Add("1F");
                TXTSECTION.Items.Add("1G");
                TXTSECTION.Items.Add("1H");
            }
            else if (TXTYEARLEVEL.Text == "2ND YEAR")
            {
                TXTSECTION.Items.Clear();
                TXTSECTION.Items.Add("2A");
                TXTSECTION.Items.Add("2B");
                TXTSECTION.Items.Add("2C");
                TXTSECTION.Items.Add("2D");
                TXTSECTION.Items.Add("2E");
                TXTSECTION.Items.Add("2F");
                TXTSECTION.Items.Add("2G");
                TXTSECTION.Items.Add("2H");
            }
            else if (TXTYEARLEVEL.Text == "3RD YEAR")
            {
                TXTSECTION.Items.Clear();
                TXTSECTION.Items.Add("3A");
                TXTSECTION.Items.Add("3B");
                TXTSECTION.Items.Add("3C");
                TXTSECTION.Items.Add("3D");
                TXTSECTION.Items.Add("3E");
                TXTSECTION.Items.Add("3F");
                TXTSECTION.Items.Add("3G");
                TXTSECTION.Items.Add("3H");
            }
            else if (TXTYEARLEVEL.Text == "4TH YEAR")
            {
                TXTSECTION.Items.Clear();
                TXTSECTION.Items.Add("4A");
                TXTSECTION.Items.Add("4B");
                TXTSECTION.Items.Add("4C");
                TXTSECTION.Items.Add("4D");
                TXTSECTION.Items.Add("4E");
                TXTSECTION.Items.Add("4F");
                TXTSECTION.Items.Add("4G");
                TXTSECTION.Items.Add("4H");
            }

        }
        private void scode()
        {

            if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CC101");
                txtsubcode.Items.Add("CC102");
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
                txtsubcode.Items.Add("PDP1");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CC103");
                txtsubcode.Items.Add("DS101");
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
                txtsubcode.Items.Add("PDP2");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CC104");
                txtsubcode.Items.Add("DS102");
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("SDF104");
                txtsubcode.Items.Add("PE3");
                txtsubcode.Items.Add("PDP3");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CC105");
                txtsubcode.Items.Add("AL101");
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("GE10");
                txtsubcode.Items.Add("MATH ELE");
                txtsubcode.Items.Add("PE4");
                txtsubcode.Items.Add("PDP4");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CC106");
                txtsubcode.Items.Add("AL102");
                txtsubcode.Items.Add("GE11");
                txtsubcode.Items.Add("GE12");
                txtsubcode.Items.Add("AR101");
                txtsubcode.Items.Add("IAS101");
                txtsubcode.Items.Add("GV101");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("SE101");
                txtsubcode.Items.Add("PL101");
                txtsubcode.Items.Add("GE13");
                txtsubcode.Items.Add("GE14");
                txtsubcode.Items.Add("SP101");
                txtsubcode.Items.Add("IS101");
                txtsubcode.Items.Add("CN101");
                txtsubcode.Items.Add("PRAC101");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("OS101");
                txtsubcode.Items.Add("SE102");
                txtsubcode.Items.Add("GE15");
                txtsubcode.Items.Add("GE16");
                txtsubcode.Items.Add("SF101");
                txtsubcode.Items.Add("HCI101");
                txtsubcode.Items.Add("THS101");
            }
            else if (txtcourse.Text == "BSCS" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("NC101");
                txtsubcode.Items.Add("PD101");
                txtsubcode.Items.Add("GE17");
                txtsubcode.Items.Add("GE18");
                txtsubcode.Items.Add("THS102");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("THC1");
                txtsubcode.Items.Add("THC2");
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
                txtsubcode.Items.Add("PDP1");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("THC3");
                txtsubcode.Items.Add("THC4");
                txtsubcode.Items.Add("THC5");
                txtsubcode.Items.Add("HPC1");
                txtsubcode.Items.Add("HPC2");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
                txtsubcode.Items.Add("PDP2");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("GE ELECTIVE 1");
                txtsubcode.Items.Add("HPC3");
                txtsubcode.Items.Add("HPC4");
                txtsubcode.Items.Add("HPC5");
                txtsubcode.Items.Add("HMPE1");
                txtsubcode.Items.Add("PE3");
                txtsubcode.Items.Add("PDP3");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("HPC6");
                txtsubcode.Items.Add("HPC7");
                txtsubcode.Items.Add("HPC8");
                txtsubcode.Items.Add("HMPE2");
                txtsubcode.Items.Add("HMPE3");
                txtsubcode.Items.Add("PE4");
                txtsubcode.Items.Add("PDP4");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("HMPE4");
                txtsubcode.Items.Add("HMPE5");
                txtsubcode.Items.Add("BME1");
                txtsubcode.Items.Add("THC6");
                txtsubcode.Items.Add("THC7");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("BME2");
                txtsubcode.Items.Add("THC8");
                txtsubcode.Items.Add("THC9");
                txtsubcode.Items.Add("THC10");
                txtsubcode.Items.Add("HPC9");
                txtsubcode.Items.Add("HMPE6");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("HMPE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("HPC10");
                txtsubcode.Items.Add("GE ELECTIVE 2");
                txtsubcode.Items.Add("GE ELECTIVE 3");
                txtsubcode.Items.Add("GE9");
            }
            else if (txtcourse.Text == "BSHM" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("PRAC");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("THC1");
                txtsubcode.Items.Add("THC2");
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
                txtsubcode.Items.Add("PDP1");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("TPC1");
                txtsubcode.Items.Add("THC3");
                txtsubcode.Items.Add("THC4");
                txtsubcode.Items.Add("THC5");
                txtsubcode.Items.Add("TMCC1");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
                txtsubcode.Items.Add("PDP2");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("GE ELECTIVE 1");
                txtsubcode.Items.Add("TPC2");
                txtsubcode.Items.Add("TPC3");
                txtsubcode.Items.Add("HMPE1");
                txtsubcode.Items.Add("PE3");
                txtsubcode.Items.Add("PDP3");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("TPC4");
                txtsubcode.Items.Add("TPC5");
                txtsubcode.Items.Add("HMPE2");
                txtsubcode.Items.Add("TPC6");
                txtsubcode.Items.Add("PDP4");
                txtsubcode.Items.Add("PE4");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("TPC7");
                txtsubcode.Items.Add("HMPE3");
                txtsubcode.Items.Add("BME1");
                txtsubcode.Items.Add("THC6");
                txtsubcode.Items.Add("THC7");
                txtsubcode.Items.Add("MICE1");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("THC8");
                txtsubcode.Items.Add("BME2");
                txtsubcode.Items.Add("HMPE4");
                txtsubcode.Items.Add("THC9");
                txtsubcode.Items.Add("THC10");
                txtsubcode.Items.Add("TPC8");
                txtsubcode.Items.Add("MICE2");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("HMPE5");
                txtsubcode.Items.Add("RIZAL");
                txtsubcode.Items.Add("TPC9");
                txtsubcode.Items.Add("GE ELECTIVE 2");
                txtsubcode.Items.Add("GE ELECTIVE 3");
                txtsubcode.Items.Add("GE8");
            }
            else if (txtcourse.Text == "BSTM" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("PRAC");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
                txtsubcode.Items.Add("PDP1");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("BA1");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
                txtsubcode.Items.Add("PDP2");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("GE ELECTIVE 1");
                txtsubcode.Items.Add("GE ELECTIVE 2");
                txtsubcode.Items.Add("BA CC1");
                txtsubcode.Items.Add("BA2");
                txtsubcode.Items.Add("PROF1");
                txtsubcode.Items.Add("PE3");
                txtsubcode.Items.Add("PDP3");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE ELECTIVE 3");
                txtsubcode.Items.Add("PROF ELECTIVE");
                txtsubcode.Items.Add("BA CC2");
                txtsubcode.Items.Add("BA CC3");
                txtsubcode.Items.Add("PROF2");
                txtsubcode.Items.Add("PROF3");
                txtsubcode.Items.Add("PE4");
                txtsubcode.Items.Add("PDP4");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CBMEC");
                txtsubcode.Items.Add("BA CC4");
                txtsubcode.Items.Add("BA CC5");
                txtsubcode.Items.Add("BA CC6");
                txtsubcode.Items.Add("PROF4");
                txtsubcode.Items.Add("PROF5");
                txtsubcode.Items.Add("BA3");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("BA CC6");
                txtsubcode.Items.Add("BMEC");
                txtsubcode.Items.Add("PROF6");
                txtsubcode.Items.Add("PROF7");
                txtsubcode.Items.Add("ELECTIVE 1");
                txtsubcode.Items.Add("BA4");
                txtsubcode.Items.Add("BA5");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("PROF8");
                txtsubcode.Items.Add("ELECTIVE 2");
                txtsubcode.Items.Add("ELECTIVE 3");
                txtsubcode.Items.Add("BA CC8");
                txtsubcode.Items.Add("PROF ELECTIVE 4");
                txtsubcode.Items.Add("BA6");
            }
            else if (txtcourse.Text == "BSBA" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("ELECTIVE 4");
                txtsubcode.Items.Add("PRACTICUM");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("EDUC101");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
                txtsubcode.Items.Add("PDP1");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("GE10");
                txtsubcode.Items.Add("GE11");
                txtsubcode.Items.Add("GE12");
                txtsubcode.Items.Add("EDUC102");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
                txtsubcode.Items.Add("PDP2");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("TTL1");
                txtsubcode.Items.Add("EDUC103");
                txtsubcode.Items.Add("SCI1");
                txtsubcode.Items.Add("MATH1");
                txtsubcode.Items.Add("SSC1");
                txtsubcode.Items.Add("FIL1");
                txtsubcode.Items.Add("VED");
                txtsubcode.Items.Add("PE3");
                txtsubcode.Items.Add("PDP3");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("EDUC104");
                txtsubcode.Items.Add("EDUC105");
                txtsubcode.Items.Add("SCI2");
                txtsubcode.Items.Add("MATH2");
                txtsubcode.Items.Add("MTB-MLE");
                txtsubcode.Items.Add("SSC2");
                txtsubcode.Items.Add("TLE1");
                txtsubcode.Items.Add("PE4");
                txtsubcode.Items.Add("PDP4");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("ENG1");
                txtsubcode.Items.Add("EDUC106");
                txtsubcode.Items.Add("TTL2");
                txtsubcode.Items.Add("EDUC107");
                txtsubcode.Items.Add("MUSIC");
                txtsubcode.Items.Add("ENG2");
                txtsubcode.Items.Add("ARTS");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("EDUC108");
                txtsubcode.Items.Add("EDUC109");
                txtsubcode.Items.Add("ELEC");
                txtsubcode.Items.Add("PEH");
                txtsubcode.Items.Add("FIL2");
                txtsubcode.Items.Add("RES");
                txtsubcode.Items.Add("TLE2");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("FS1");
                txtsubcode.Items.Add("FS2");
            }
            else if (txtcourse.Text == "BEED" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("TI");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("LING1");
                txtsubcode.Items.Add("LING2");
                txtsubcode.Items.Add("LING3");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("ELT1");
                txtsubcode.Items.Add("ELT2");
                txtsubcode.Items.Add("ELT3");
                txtsubcode.Items.Add("EDUC101");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("GE10");
                txtsubcode.Items.Add("ELT4");
                txtsubcode.Items.Add("ELT5");
                txtsubcode.Items.Add("ELT6");
                txtsubcode.Items.Add("EDUC102");
                txtsubcode.Items.Add("ELT7");
                txtsubcode.Items.Add("PE3");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("ELT8");
                txtsubcode.Items.Add("LIT101");
                txtsubcode.Items.Add("LIT102");
                txtsubcode.Items.Add("LIT103");
                txtsubcode.Items.Add("GE11");
                txtsubcode.Items.Add("GE12");
                txtsubcode.Items.Add("EDUC109");
                txtsubcode.Items.Add("PE4");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("LIT104");
                txtsubcode.Items.Add("LIT105");
                txtsubcode.Items.Add("LIT106");
                txtsubcode.Items.Add("LIT107");
                txtsubcode.Items.Add("TTL1");
                txtsubcode.Items.Add("EDUC103");
                txtsubcode.Items.Add("EDUC105");
                txtsubcode.Items.Add("EDUC107");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("CJ");
                txtsubcode.Items.Add("ELT9");
                txtsubcode.Items.Add("TTL2");
                txtsubcode.Items.Add("ELECTIVE 1");
                txtsubcode.Items.Add("ELECTIVE 2");
                txtsubcode.Items.Add("EDUC104");
                txtsubcode.Items.Add("EDUC106");
                txtsubcode.Items.Add("EDUC108");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("FS1");
                txtsubcode.Items.Add("FS2");
            }
            else if (txtcourse.Text == "ENG" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("TI");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("M100");
                txtsubcode.Items.Add("M101");
                txtsubcode.Items.Add("TSF");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("M102");
                txtsubcode.Items.Add("M103");
                txtsubcode.Items.Add("M104");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("GE10");
                txtsubcode.Items.Add("EDUC101");
                txtsubcode.Items.Add("TP");
                txtsubcode.Items.Add("M106");
                txtsubcode.Items.Add("M109");
                txtsubcode.Items.Add("M110");
                txtsubcode.Items.Add("PE3");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE11");
                txtsubcode.Items.Add("GE12");
                txtsubcode.Items.Add("EDUC109");
                txtsubcode.Items.Add("M107");
                txtsubcode.Items.Add("M111");
                txtsubcode.Items.Add("M112");
                txtsubcode.Items.Add("M105");
                txtsubcode.Items.Add("PE4");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("M108");
                txtsubcode.Items.Add("M113");
                txtsubcode.Items.Add("M115");
                txtsubcode.Items.Add("M116");
                txtsubcode.Items.Add("EDUC103");
                txtsubcode.Items.Add("EDUC105");
                txtsubcode.Items.Add("EDUC107");
                txtsubcode.Items.Add("TTL1");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("M114");
                txtsubcode.Items.Add("M117");
                txtsubcode.Items.Add("M118");
                txtsubcode.Items.Add("M119");
                txtsubcode.Items.Add("EDUC104");
                txtsubcode.Items.Add("EDUC106");
                txtsubcode.Items.Add("EDUC108");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("FS1");
                txtsubcode.Items.Add("FS2");
            }
            else if (txtcourse.Text == "MATH" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("TI");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE1");
                txtsubcode.Items.Add("GE2");
                txtsubcode.Items.Add("GE3");
                txtsubcode.Items.Add("SOCSCI101");
                txtsubcode.Items.Add("BAPOL1");
                txtsubcode.Items.Add("NSTP1");
                txtsubcode.Items.Add("PE1");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "1ST YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE4");
                txtsubcode.Items.Add("GE5");
                txtsubcode.Items.Add("GE6");
                txtsubcode.Items.Add("BAPOL2");
                txtsubcode.Items.Add("NSTP2");
                txtsubcode.Items.Add("PE2");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE7");
                txtsubcode.Items.Add("GE8");
                txtsubcode.Items.Add("SOCSCI 0");
                txtsubcode.Items.Add("BAPOL3");
                txtsubcode.Items.Add("PE3");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "2ND YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("GE9");
                txtsubcode.Items.Add("BAPOL4");
                txtsubcode.Items.Add("BAPOL5");
                txtsubcode.Items.Add("PE4");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("BAPOL6");
                txtsubcode.Items.Add("BAPOL7");
                txtsubcode.Items.Add("POL ELECTIVE 1");
                txtsubcode.Items.Add("0 ELECTIVE 1");
                txtsubcode.Items.Add("FRE ELECTIVE 1");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "3RD YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("BAPOL8");
                txtsubcode.Items.Add("BAPOL9");
                txtsubcode.Items.Add("POL ELECTIVE 2");
                txtsubcode.Items.Add("0 ELECTIVE 2");
                txtsubcode.Items.Add("FRE ELECTIVE 2");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "1ST SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("BAPOL10");
                txtsubcode.Items.Add("POL ELECTIVE 3");
                txtsubcode.Items.Add("FRE ELECTIVE 3");
            }
            else if (txtcourse.Text == "POLSCI" && TXTYEARLEVEL.Text == "4TH YEAR" && txtsem.Text == "2ND SEMESTER")
            {
                txtsubcode.Items.Clear();
                txtsubcode.Items.Add("0 ELECTIVE 3");
                txtsubcode.Items.Add("FRE ELECTIVE 6");
                txtsubcode.Items.Add("FRE ELECTIVE 5");
            }
        }
        private void subdesunit()
        {
            if (txtsubcode.Text == "CC101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INTRODUCTION TO PROGRAMMING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CC102" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "FUNDAMENTALS OF PROGRAMMING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "COMMUNICATION SKILLS 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "KOMUNIKASYON SA AKADEMIKONG FILIPINO";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "COLLEGE ALGEBRA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "NSTP1")
            {
                txtsubdes.Text = "NATIONAL SERVICE TRAINING PROGRAM 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PE1")
            {
                txtsubdes.Text = "PHYSICAL FITNESS";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "PDP1")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT PROGRAM 1";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "CC103" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INTERMEDIATE PROGRAMMING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "COMMUNICATION SKILLS 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PAGBASA AT PAGSULAT TUNGO SA PANANALIKSIK";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "DS101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "DISCRETE STRUCTURES 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "NSTP2")
            {
                txtsubdes.Text = "NATIONAL SERVICE TRAINING PROGRAM 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PE2")
            {
                txtsubdes.Text = "RHYTHMIC ACTIVITIES";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "PDP2")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT PROGRAM 2";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "SPEECH AND ORAL COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PROBABILITIES AND STATISTICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CC104" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "DATA STRUCTURES AND ALGORITHMS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "DS102" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "DISCRETE STRUCTURES 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SDF104" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "OBJECT-ORIENTED PROGRAMMING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PE3")
            {
                txtsubdes.Text = "INDIVIDUAL AND DUAL SPORTS";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "PDP3")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT PROGRAM 3";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "COLLEGE PHYSICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE10" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INTRODUCTION TO LITERATURE INCLUDING PHILIPPINE SETTING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CC105" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INFORMATION MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "AL101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ALGORITHMS AND COMPLEXITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MATH ELE" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "DISCRETE MATHEMATICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PE4")
            {
                txtsubdes.Text = "TEAM SPORTS";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "PDP4")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT PROGRAM 4";
                txtunits.Text = "2";
            }
            else if (txtsubcode.Text == "GE11" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "TRIGONOMETRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE12" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PHILOSOPHY OF MAN AND ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CC106" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "APPLICATION DEVELOPMENT AND EMERGING TECHNOLOGIES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "AL102" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "AUTOMATA THEORY AND FORMAL LANGUAGES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "AR101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ARCHITECTURE AND ORGANIZATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "IAS101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INFORMATION ASSURANCE AND SECURITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GV101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "GRAPHICS AND VISUAL COMPUTING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE13" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ELECTRICITY AND ELECTROMAGNETISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE14" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PL101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PROGRAMMING LANGUAGES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SE101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "SOFTWARE ENGINEERING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SP101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "SOCIAL ISSUES AND PROFESSIONAL PRACTICE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "IS101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "INTELLIGENT SYSTEMS (ELECTIVE)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CN101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "COMPUTATIONAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE15" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PHILIPPINE HISTORY AND CULTURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE16" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "POLITICS AND GOVERNANCE (w/ PHILIPPINE CONSTITUTION)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "0S101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "OPERATING SYSTEMS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SE102" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "SOFTWARE ENGINEERING 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SF101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "SYSTEM FUNDAMENTALS (ELECTIVE)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HCI101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "HUMAN COMPUTER INTERACTION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THS101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "CS THESIS WRITING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE17" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ECONOMICS (W/ TAXATION AND AGRARIAN REFORM INTEGRATED)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE18" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "ASIAN/WESTERN CIVILIZATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "NC101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "NETWORKS AND COMMUNICATIONS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PD101" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "PARALLEL AND DISTRIBUTED COMPUTING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THS102" && txtcourse.Text == "BSCS")
            {
                txtsubdes.Text = "CS THESIS WRITING 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "READINGS IN PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "MACRO PERSPECTIVE OF TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "RISK MANAGEMENT AS APPLIED TO SAFETY, SECURITY, AND SANITATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC3" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "QUALITY SERVICE MANAGEMENT IN TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC4" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "PHILIPPINE TOURISM, GEOGRAPHY, AND CULTURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC5" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "MICRO PERSPECTIVE OF TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "FUNDAMENTALS IN LODGING OPERATIONS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "KITCHEN ESSENTIALS AND BASIC FOOD PREPARATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ENVIRONMENTAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC3" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "APPLIED BUS TOOLS AND TECHNOLOGIES (PMS) WITH LAB";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC4" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "SUPPLY CHAIN MANAGEMENT IN HOSPITALITY INDUSTRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC5" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "FOREIGN LANGUAGE 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ASIAN CUISINE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY, AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC6" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "FUNDAMENTALS IN FOOD SERVICE OPERATIONS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC7" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "INTRODUCTION TO MICE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "BREAD AND PASTRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC8" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "FOREIGN LANGUAGE 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE3" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "CRUISE SHIP MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE4" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "BAR AND BEVARAGE MANAGEMENT W/ LAB";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE5" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "FRONT OFFICE OPERATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BME1" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "OPERATIONS MANAGEMENT IN TH INDUSTRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC6" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT AND APPLIED ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC7" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "TOURISM AND HOSPITALITY MARKETING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BME2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "STRATEGIC MANAGEMENT IN TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC8" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "LEGAL ASPECTS IN TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC9" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "MULTICULTURAL DIVERSITY IN WORKPLACE FOR THE TOURISM PROFESSIONAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC10" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ENTREPRENEURSHIP IN TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC9" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ERGONOMICS AND FACILITIES PLANNING FOR THE HOSPITALITY INDUSTRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE6" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "CATERING MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE7" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "COST CONTROL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HPC10" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "RESEARCH IN HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 2" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "Living in the IT Era";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 3" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "ENTREPRENEURIAL MIND";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PRAC" && txtcourse.Text == "BSHM")
            {
                txtsubdes.Text = "PRACTICUM (600 HOURS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "READINGS IN PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOURISM IN THE HOSPITALITY 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "RISK MANAGEMENT AS APPLIED TO SAFETY, SECURITY AND SANITATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "GLOBAL TOURISM, GEOGRAPHY AND CULTURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC3" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOURISM AND HOSPITALITY SERVICE QUALITY MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC4" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "PHILIPPINE TOURISM, GEORAPHY AND CULTURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC5" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOURISM AND HOSPITALITY 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TMCC1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOUR AND TRAVEL MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "HERITAGE TOURISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "ENVIRONMENTAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "APPLIED BUSINESS TOOLS AND TECHNOLOGIES (GDS) WITH LAB (TPC)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC3" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "SUSTAINABLE TOURISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY, AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC4" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOURISM POLICY PLANNING AND DEVELOPMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC5" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "INTRODUCTION TO MICE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOUR GUIDING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC6" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "FOREIGN LANGUAGE 1 (TPC)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC7" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "FOREIGN LANGUAGE 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE3" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "ECOTOURISM MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BME1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "OPERATIONS MANAGEMENT IN TH INDUSTY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC6" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "PROFESSIONAL DEVELOPMENT AND APPLIED ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC7" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TOURISM AND HOSPITALITY MARKETING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MICE1" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "MEETINGS MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC8" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "LEGAL ASPECTS IN TOURISM AND HOSPITALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BME2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "STRATEGIC MANAGEMENT IN TH 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE4" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "CRUISE TOURISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC9" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "MULTICULTURAL DIVERSITY IN WORKPLACE FOR THE TOURISM PROFESSIONAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "THC10" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "ENTREPRENEURSHIP IN TH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC8" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "TRANSPORTATION MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MICE2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "INCENTIVES MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "HMPE5" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "AIRPLANES OPERATIONS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "RIZAL" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TPC9" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "RESEARCH IN TOURISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 2" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "RELIGIONS, RELIGIOUS EXPERIENCES AND SPIRITUALITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 3" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "PHILIPPINE POPULAR CULTURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PRAC" && txtcourse.Text == "BSTM")
            {
                txtsubdes.Text = "PRACTICUM (600 HOURS)";
                txtunits.Text = "6";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "READINGS IN PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY, AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "FINANCIAL MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "RIZAL'S LIFE AND WORKS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "MATHEMATICS, SCIENCE AND TECHNOLOGY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "SOCIAL SCIENCE AND PHILOSOPHY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "BASIC MICROECONOMICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "BEHAVIOURAL FINANCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "COOPERATIVE MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE ELECTIVE 3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "ARTS AND HUMANITIES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF ELECTIVE" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "FRANCHISING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "BUSINESS LAW (OBLIGATIONS AND CONTRACTS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "TAXATION (INCOME TAXATION)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "FINANCIAL ANALYSIS AND REPORTING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "BANKING AND FINANCIAL INSTITUTION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CBMEC" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "STRATEGIC MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "GOOD GOVERNANCE AND SOCIAL RESPONSIBILITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC5" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "HUMAN RESOURCE MANAGEMENTS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC6" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "INTERNATIONAL TRADE AND AGREEMENTS ";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "MONETARY POLICY AND CENTRAL BANKING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF5" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "INVESTMENT AND PORTFOLIO MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "GLOBAL FINANCE WITH ELECTRONIC BANKING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC6" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "BUSINESS RESEARCH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BMEC" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "OPERATIONS MANAGEMENT (TQM)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF6" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "CREDIT AND COLLECTION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF7" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "CAPITAL MARKET";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 1" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "RISK MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "MANAGEMENT INFORMATION SYSTEM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA5" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "TREASURY MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF8" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "THE POLITICAL ECONOMY AND TRADE POLICY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 2" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "ENTREPRENEURIAL MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 3" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "PROJECT MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA CC8" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "FEASIBILITY STUDY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PROF ELECTIVE 4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "VENTURE CAPITAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BA6" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "MUTUAL CAPITAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 4" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "PUBLIC FINANCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PRACTICUM" && txtcourse.Text == "BSBA")
            {
                txtsubdes.Text = "WORK INTEGRATED LEARNING";
                txtunits.Text = "6";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "READINGS IN PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC101" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "THE CHILD AND ADOLESCENT LEARNERS AND LEARNING PRINCIPLES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "LIVING IN THE IT ERA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE10" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "GENDER AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE11" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "READING VISUAL ARTS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE12" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC102" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "THE TEACHING PROFESSION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TTL1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING AND LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC103" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "FACILITATING LEARNING-CENTERED TEACHING)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SCI1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING SCIENCE IN ELEMENTARY GRADES (BIOLOGY AND CHEMISTRY)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MATH1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING MATH IN THE PRIMARY GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SSC1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING SOCIAL STUDIES IN ELEMENTARY GRADES (PHILIPPINE HISTORY AND GOVERNMENT)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FIL1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "PAGTUTURO AND FILIPINO SA ELEMENTARYA(1)\n ESTRAKTURA AT GAMIT NG WIKANG FILIPINO";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "VED" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "GOOD MANNERS AND RIGHT CONDUCT (EDUKASYON SA PAGPAPAKATAO)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC104" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "BUILDING AND ENHANCING NEW LITERACIES ACROSS THE CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC105" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "FOUNDATION OF SPECIAL AND INCLUSIVE EDUCATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SCI2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING SCIENCE IN THE ELEMENTARY GRADES \n ()PHYSICS, EARTH AND SPACE SCIENCE)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MATH2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING MATH IN THE INTERMEDIATE GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MTB-MLE" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "CONTENT AND PEDAGOGY FOR THE MOTHER TOUNGE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SSC2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING SOCIAL STUDIES IN THE ELEMENTARY GRADES (CULTURE AND GEOGRAPHY)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TLE1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "EDUKASYON PANTAHANAN AT PANGKABUHAYAN";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ENG1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING ENGLISH IN THE ELEMENTARY GRADES (LANGUAGE ARTS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC106" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "THE TEACHER AND THE SCHOOL CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TTL2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING IN THE ELEMENTARY GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC107" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "MUSIC" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING MUSIC IN THE ELEMENTARY GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ENG2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING ENGLISH IN THE ELEMENTARY GRADES THROUGH LITERATURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ARTS" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING ARTS IN THE ELEMENTARY GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC108" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC109" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "THE TEACHER AND THE COMMUNITY, SCHOOL CULTURE AND ORGANIZATIONAL LEADERSHIP";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELEC" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING MULTI-GRADE CLASSES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "PEH" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING PE AND HEALTH IN THE ELEMENTARY GRADES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FIL2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "PAGTUTURO NG FILIPINO SA ELEMENTARYA (II) PANITIKAN NG PILIPINAS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "RES" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "RESEARCH IN EDUCATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TLE2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "EDUKASYON PANTAHANAN AT PANGKABUHAYAN WITH ENTREPRENEURSHIP";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS1" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "FIELD STUDY 1 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS2" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "FIELD STUDY 2 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TI" && txtcourse.Text == "BEED")
            {
                txtsubdes.Text = "TEACHING INTERNSHIP (OFF-CAMPUS)";
                txtunits.Text = "6";
            }
            else if (txtsubcode.Text == "LING1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "INTRODUCTION TO LINGUISTICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LING2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LANGUAGE, CULTURE AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LING3" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "STRUCTURES OF ENGLISH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "READINGS IN PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "PRINCIPLE AND THEORIES OF LANGUAGE ACQUISITION AND LEARNING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LANGUAGE PROGRAMS AND POLICIES IN MULTILINGUAL SOCIETIES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT3" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LANGUAGE LEARNING MATERIALS DEVELOPMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC101" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "THE CHILD AND ADOLESCENT LEARNER AND LEARNING PRINCIPLES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT4" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TEACHING AND ASSESSMENT OF LITERATURE STUDIES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT5" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TEACHING AND ASSESSMENT OF THE MACROSKILLS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT6" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TEACHING AND ASSESSMENT OF GRAMMAR";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT7" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "SPEECH AND THEATER ARTS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LIVING IN THE IT ERA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE10" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "GENDER AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC102" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "THE TEACHING PROFESSION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT8" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LANGUAGE EDUCATION RESEARCH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT101" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "CHILDREN AND ADOLESCENT LITERATURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT102" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "MYTHOLOGY AND FOLKLORE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT103" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "SURVEY OF PHILIPPINE LITERATURE IN ENGLISH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE11" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "READING AND VISUAL ARTS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE12" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC109" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "THE TEACHER AND THE COMMUNITY, SCHOOL CULTURE AND ORGANIZATIONAL LEADERSHIP";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT104" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "SURVEY OF AFRO-ASIAN LITERATURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT105" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "SURVEY OF ENGLISH AND AMERICAN LITERATURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT106" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "CONTEMPORARY, POPULAR, AND EMERGENT LITERATURE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "LIT107" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "LITERARY CRITICISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TTL1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING AND LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC103" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "FACILITATING LEARNER-CENTERED TEACHING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC105" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "FOUNDATION OF SPECIAL AND INCLUSIVE EDUCATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC107" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "CJ" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "CAMPUS JOURNALISM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELT9" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TECHNICAL WRITING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TTL2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING AND LEARNING 2 (TECHNOLOGY IN LANGUAGE EDUCATION)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "ENGLISH FOR SPECIFIC PURPOSES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "ELECTIVE 2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "CREATIVE WRITING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC104" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "BUILDING AND ENHANCING NEW LITERACIES ACROSS THE CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC106" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "THE TEACHER AND THE SCHOOL CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC108" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS1" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "FIELD STUDY 1 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS2" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "FIELD STUDY 2 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TI" && txtcourse.Text == "ENG")
            {
                txtsubdes.Text = "TEACHING INTERNSHIP";
                txtunits.Text = "6";
            }
            else if (txtsubcode.Text == "M100" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "HISTORY OF MATHEMATICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M101" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "COLLEGE AND ADVANCED ALGEBRA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TSF" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "TEACHING IN THE SPECIALIZED FIELD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "READINGS IN THE PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M102" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "TRIGONOMETRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M103" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "PLANE AND SOLID GEOMETRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M104" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "LOGIC AND SET THEORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M106" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "CALCULUS I WITH ANALYTIC GEOMETRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M109" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "MODERN GEOMETRY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M110" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "MATHEMATICS OF INVESTMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "LIVING IN THE IT ERA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE10" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "GENDER AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC101" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "THE CHILKD AND ADOLESCENT LEARNER AND LEARNING PRINCIPLES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TP" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "THE TEACHING PROFESSION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M107" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "CALCULUS 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M111" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "NUMBER THEORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M112" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "LINEAR ALGEBRA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M105" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ELEMENTARY STATISTICS AND PROBABILITY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE11" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "READING VISUAL ARTS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE12" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC109" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "THE TEACHER AND THE COMMUNITY, SCHOOL CULTURE AND ORGANIZATIONAL LEADERSHIP";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M108" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "CALCULUS 3";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M113" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ADVANCED STATISTICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M115" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "PROBLEM SOLVING, MATHEMATICAL INVESTIGATION AND MODELING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M116" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "PRINCIPLES AND STRATEGIES IN TEACHING MATHEMATICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC103" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "FACILITATING LEARNER-CENTERED TEACHING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC105" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "FOUNDATION OF SPECIAL AND INCLUSIVE EDUCATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC107" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TTL1" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING AND LEARNING 1";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M114" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ABSTRACT ALGEBRA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M117" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "TECHNOLOGY FOR TEACHING AND LEARNING 2 (INSTRUMENTATION AND TECHNOLOGY IN MATHEMATICS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M118" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "RESEARCH IN MATHEMATICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "M119" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ASSESSMENT AND EVALUATION IN MATHEMATICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC104" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "BUILDING AND ENHANCING NEW LITERACIES ACROSS CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC106" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "THE TEACHER AND THE SCHOOL CURRICULUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "EDUC108" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "ASSESSMENT IN LEARNING 2";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS1" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "FIELD STUDY 1 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FS2" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "FIELD STUDY 2 (IN-CAMPUS)";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "TI" && txtcourse.Text == "MATH")
            {
                txtsubdes.Text = "TEACHING INTERNSHIP (OFF-CAMPUS)";
                txtunits.Text = "6";
            }
            else if (txtsubcode.Text == "GE1" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "PURPOSIVE COMMUNICATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE2" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "LIFE AND WORKS OF RIZAL";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE3" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "UNDERSTANDING THE SELF";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SOCSCI101" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "FOUNDATION OF BEHAVIORAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL1" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "FUNDAMENTALS OF POLITICAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE4" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "MATHEMATICS IN THE MODERN WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE5" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "READINGS IN THE PHILIPPINE HISTORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL2" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTRODUCTION TO PHILIPPINE POLITICS AND GOVERNANCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE6" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "ART APPRECIATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE7" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "ETHICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL3" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTRODUCTION TO POLITICAL ANALYSIS AND RESEARCH";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE8" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "THE CONTEMPORARY WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "SOCSCI 0" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "AGUMENTATION AND DEBATE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "GE9" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "SCIENCE, TECHNOLOGY AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL4" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTRODUCTION TO POLITICAL THEORY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL5" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "QUALITATIVE AND QUANTITATIVE ANALYSIS OF POLITICAL DATA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL6" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTRODUCTION TO COMPERATIVE GOVERNMENT AND POLITICS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL7" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "PHILIPPINE PUBLIC ADMINISTRATION";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "POL ELECTIVE 1" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "PUBLIC INTERNATIONAL LAW FOR POLITICAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "0 ELECTIVE 1" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "E-GOVERNANCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FRE ELECTIVE 1" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "POLITICAL DEVELOPMENT IN THE DEVELOPING WORLD";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL8" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTROUDUCTION TO INTERNATIONAL RELATIONS";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL9" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "POLITICS AND GOVERNANCE IN SOUTHEAST ASIA";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "POL ELECTIVE 2" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "GLOBAL POLITICAL FORCES AND ENVIRONMENTAL CHANGE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "0 ELECTIVE 2" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTERNATIONAL POLITICAL ECONOMY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FRE ELECTIVE 2" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "LAW, POLITICS AND SOCIETY";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "POL ELECTIVE 3" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "PUBLIC POLICY ANALYSIS AND PLANNING";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FRE ELECTIVE 3" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "INTERNATIONAL CONFLICT RESOLUTION, POLITICAL VIOLENCE AND PEACE STUDIES";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "BAPOL10" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "PRACTICUM";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "0 ELECTIVE 3" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "LOCAL GOVERNMENT AND DEVELOPMENT MANAGEMENT";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FRE ELECTIVE 4" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "SEMINAR IN POLITICAL SCIENCE";
                txtunits.Text = "3";
            }
            else if (txtsubcode.Text == "FRE ELECTIVE 5" && txtcourse.Text == "POLSCI")
            {
                txtsubdes.Text = "RESEARCH IN POLITICAL SCIENCE";
                txtunits.Text = "3";
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            dashboard ds = new dashboard();
            ds.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dashboard ds = new dashboard();
            ds.Show();
            this.Hide();
        }

        private void GRADINGSHEET_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingsheetprojectDataSet1.REGISTRATIONFORM' table. You can move, or remove it, as needed.
            this.rEGISTRATIONFORMTableAdapter.Fill(this.gradingsheetprojectDataSet1.REGISTRATIONFORM);
           
        }

        private void txtcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            scode();
        }

        private void TXTYEARLEVEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            section();
            scode();
        }

        private void TXTSECTION_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            scode();
        }

        private void txtsubcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            subdesunit();
        }
        public void grade()
        {
            double monthly, fprelim, sprelim, midterm, pfinals, finals, genave;

            monthly = Convert.ToDouble(textBox1.Text);
            fprelim = Convert.ToDouble(textBox2.Text);
            sprelim = Convert.ToDouble(textBox3.Text);
            midterm = Convert.ToDouble(textBox6.Text);
            pfinals = Convert.ToDouble(textBox5.Text);
            finals = Convert.ToDouble(textBox4.Text);

            genave = (monthly + fprelim + sprelim + midterm + pfinals + finals) / 6;
            genave = Math.Round(genave, 2, MidpointRounding.AwayFromZero);

            textBox8.Text = genave.ToString("0.00");



            if (genave >= 96.5 && genave <= 100)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "1.00";
            }
            else if (genave >= 93.5 && genave <= 96.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "1.25";
            }
            else if (genave >= 90.5 && genave <= 93.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "1.50";
            }
            else if (genave >= 87.5 && genave <= 90.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "1.75";
            }
            else if (genave >= 84.5 && genave <= 87.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "2.00";
            }
            else if (genave >= 81.5 && genave <= 84.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "2.25";
            }
            else if (genave >= 78.5 && genave <= 81.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "2.50";
            }
            else if (genave >= 75.5 && genave <= 78.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "2.75";
            }
            else if (genave >= 74.5 && genave <= 75.4)
            {
                textBox10.Text = "PASSED";
                textBox9.Text = "3.00";
            }
            else if (genave <= 74.4)
            {
                textBox10.Text = "FAILED";
                textBox9.Text = "5.00";
            }

            else
            {
                textBox10.Text = "INVALID";
                textBox9.Text = "INVALID";
                textBox8.Text = "INVALID";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grade();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            long student = Convert.ToInt64(textBox13.Text);

            string query = "UPDATE REGISTRATIONFORM SET [MONTHLY] = @Monthly, [1ST PRELIMS] = @Fprelim, [2ND PRELIMS] = @Sprelim, [MIDTERMS] = @Midterm, [PREFINALS] = @Pfinals, [FINALS] = @Finals, [GENERAL AVERAGE] = @Genave, [EQUIVALENT] = @Equivalent, [REMARKS] = @Remarks WHERE [STUDENT_NUMBER] = @ID";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Monthly", textBox1.Text);
                    command.Parameters.AddWithValue("@Fprelim", textBox2.Text);
                    command.Parameters.AddWithValue("@Sprelim", textBox3.Text);
                    command.Parameters.AddWithValue("@Midterm", textBox6.Text);
                    command.Parameters.AddWithValue("@Pfinals", textBox5.Text);
                    command.Parameters.AddWithValue("@Finals", textBox4.Text);
                    command.Parameters.AddWithValue("@Genave", textBox8.Text);
                    command.Parameters.AddWithValue("@Equivalent", textBox9.Text);
                    command.Parameters.AddWithValue("@Remarks", textBox10.Text);
                    command.Parameters.AddWithValue("@ID", student);
                    command.ExecuteNonQuery();
                }

                connection.Close();

                databasesuccess ds = new databasesuccess();
                ds.Show();

                reset();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            search();

        }
        private void reset()
        {
            if (!string.IsNullOrEmpty(txtcourse.Text) && !string.IsNullOrEmpty(TXTSECTION.Text) && !string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrEmpty(TXTYEARLEVEL.Text) && !string.IsNullOrEmpty(txtsem.Text) && !string.IsNullOrEmpty(txtsubcode.Text) && !string.IsNullOrEmpty(txtsubdes.Text) && !string.IsNullOrEmpty(txtunits.Text))
            {
                string query = "SELECT * FROM REGISTRATIONFORM " + "WHERE [COURSE] = @Course " + "AND [SUBJECT CODE] = @SubjectCode " + "AND [SECTION] = @Section " + "AND [YEAR LEVEL] = @YearLevel " + "AND [SCHOOL YEAR] = @SchoolYear " + "AND [SEMESTER] = @Semester";

                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Course", txtcourse.SelectedItem);
                        command.Parameters.AddWithValue("@SubjectCode", txtsubcode.SelectedItem);
                        command.Parameters.AddWithValue("@Section", TXTSECTION.SelectedItem);
                        command.Parameters.AddWithValue("@YearLevel", TXTYEARLEVEL.SelectedItem);
                        command.Parameters.AddWithValue("@SchoolYear", comboBox3.SelectedItem);
                        command.Parameters.AddWithValue("@Semester", txtsem.SelectedItem);

                        DataTable dt = new DataTable();

                        using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                        {
                            da.Fill(dt);
                        }


                        dataGridView1.DataSource = dt;

                    }
                    connection.Close();
                }
            }
        }
        private void search()
        {
            if (!string.IsNullOrEmpty(txtcourse.Text) && !string.IsNullOrEmpty(TXTSECTION.Text) && !string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrEmpty(TXTYEARLEVEL.Text) && !string.IsNullOrEmpty(txtsem.Text) && !string.IsNullOrEmpty(txtsubcode.Text) && !string.IsNullOrEmpty(txtsubdes.Text) && !string.IsNullOrEmpty(txtunits.Text))
            {
                string query = "SELECT * FROM REGISTRATIONFORM " + "WHERE [COURSE] = @Course " + "AND [SUBJECT CODE] = @SubjectCode " + "AND [SECTION] = @Section " + "AND [YEAR LEVEL] = @YearLevel " + "AND [SCHOOL YEAR] = @SchoolYear " + "AND [SEMESTER] = @Semester";

                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Course", txtcourse.SelectedItem);
                        command.Parameters.AddWithValue("@SubjectCode", txtsubcode.SelectedItem);
                        command.Parameters.AddWithValue("@Section", TXTSECTION.SelectedItem);
                        command.Parameters.AddWithValue("@YearLevel", TXTYEARLEVEL.SelectedItem);
                        command.Parameters.AddWithValue("@SchoolYear", comboBox3.SelectedItem);
                        command.Parameters.AddWithValue("@Semester", txtsem.SelectedItem);

                        DataTable dt = new DataTable();

                        using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                        {
                            da.Fill(dt);
                        }


                        dataGridView1.DataSource = dt;

                    }
                    connection.Close();
                    searchsuccess ss = new searchsuccess();
                    ss.Show();
                }
            }

            else
            {
                MessageBox.Show("Attention: Please fill in all the required fields to proceed", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    private void txtcourse_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcourse.Text))
            {
                if (string.IsNullOrEmpty(txtcourse.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }

        private void TXTYEARLEVEL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTYEARLEVEL.Text))
            {
                if (string.IsNullOrEmpty(TXTYEARLEVEL.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TXTSECTION_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTSECTION.Text))
            {
                if (string.IsNullOrEmpty(TXTSECTION.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtsem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsem.Text))
            {
                if (string.IsNullOrEmpty(txtsem.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                if (string.IsNullOrEmpty(comboBox3.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtsubcode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsubcode.Text))
            {
                if (string.IsNullOrEmpty(txtsubcode.Text))
                {
                    MessageBox.Show("Warning: The following fields are required and cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtcourse.Text = "";
            TXTYEARLEVEL.Text = "";
            TXTSECTION.Text = "";
            txtsem.Text = "";
            txtsubcode.Text = "";
            comboBox3.Text = "";
            txtsubdes.Text = "";
            txtunits.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox13.Text))
            {


                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    long id = Convert.ToInt64(textBox13.Text);
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM REGISTRATIONFORM WHERE STUDENT_NUMBER = " + id + "";


                    OleDbDataReader read = command.ExecuteReader();
                    long count = 0;
                    while (read.Read())
                    {
                        count = count + 1;
                        textBox12.Text = read["STUDENT_NAME"].ToString();
                        textBox11.Text = read["GENDER"].ToString();
                    }
                    if (count >= 1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No data found. Please try again.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Attention: Please fill in all the required fields to proceed", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            TextBox textBox1 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox2 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "0";
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox3 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "0";
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox6 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Text = "0";
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox5 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Text = "0";
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox4 = sender as TextBox;
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = "0";
            }
        }
    }
}

