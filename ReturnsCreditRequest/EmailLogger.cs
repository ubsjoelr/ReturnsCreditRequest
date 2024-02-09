using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Configuration;

namespace ReturnsCreditRequest
{
    class EmailLogger
    {
        public static bool SendEmail(string xsTo, string subject, string body, List<string> xoAttach, List<string> xoCC, List<string> xoBC, string xsFrom)
        {
            bool pbSent = false;
            try
            {
                MailMessage mm = new MailMessage();
                mm.To.Add(xsTo);
                MailAddress from = null;
                if (xsFrom == "")
                {
                    from = new MailAddress(ConfigurationManager.AppSettings["EmailFrom"]);
                }
                else
                {
                    from = new MailAddress(xsFrom);
                }
                mm.From = from;
                mm.Subject = subject;
                mm.Body = body;

                if (xoCC != null)
                {
                    foreach (string psCC in xoCC)
                    {
                        mm.CC.Add(psCC);
                    }
                }

                if (xoBC != null)
                {
                    foreach (string psBC in xoBC)
                    {
                        mm.Bcc.Add(psBC);
                    }
                }

                if (xoAttach != null)
                {
                    foreach (string psAttach in xoAttach)
                    {
                        using (Attachment data = new Attachment(psAttach))
                        {
                            ContentDisposition disposition = data.ContentDisposition;
                            disposition.ModificationDate = System.IO.File.GetLastWriteTime(psAttach);
                            disposition.ReadDate = System.IO.File.GetLastAccessTime(psAttach);
                            mm.Attachments.Add(new Attachment(psAttach));
                        }
                    }
                }

                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
                pbSent = true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                DateTime now = DateTime.Now;
                using (StreamWriter outfile = File.AppendText(@ConfigurationManager.AppSettings["Errors"] + "EmailError.txt"))
                {
                    outfile.WriteLine(now + @" To: " + xsTo + " Subject: " + subject + " Reason: " + exc.Message.ToString());
                    outfile.Close();
                }
            }
            return pbSent;
        }
    }
}
