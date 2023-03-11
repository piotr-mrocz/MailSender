// See https://aka.ms/new-console-template for more information
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

Console.WriteLine("Hello, World!");

var email = new MimeMessage();

email.From.Add(MailboxAddress.Parse("lynn9@ethereal.email"));
email.To.Add(MailboxAddress.Parse("lynn9@ethereal.email"));

email.Subject = "Test";
email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Test</h1>" };

using var smtp = new SmtpClient();

smtp.Connect(host: "smtp.ethereal.email", port: 587, options: SecureSocketOptions.StartTls);
smtp.Authenticate("lynn9@ethereal.email", "mECh43UfCTJZWx7Dcw");
smtp.Send(email);
smtp.Disconnect(true);

Console.WriteLine("Poszło");

Console.ReadKey();