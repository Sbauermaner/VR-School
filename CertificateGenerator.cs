using UnityEngine;
using QuestPDF; // Библиотека для работы с PDF

public class CertificateGenerator : MonoBehaviour
{
    public void GenerateCertificate(string studentName, string courseName, string hash)
    {
        var certificate = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Content().Column(column =>
                {
                    column.Item().Text("Сертификат");
                    column.Item().Text(studentName);
                    column.Item().Text($"Успешно завершил курс: {courseName}");
                    column.Item().Image("Templates/Stamp.png");
                    column.Item().Text($"Хеш: {hash}");
                });
            });
        });

        certificate.GeneratePdf("certificate.pdf");
    }
}
