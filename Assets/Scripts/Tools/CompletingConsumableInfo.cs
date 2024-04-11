using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletingConsumableInfo : MonoBehaviour
{
    public int startIndex = 2;
    public CatalogueItem[] targets;

    public IEnumerator LoadDurables()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].itemQuantity = GetQttDur(i);
            targets[i].itemCost = GetCostDur(i);
            targets[i].itemDescription = GetDescriptionDur(i);
            targets[i].itemName = GetItemNameDur(i);
            targets[i].isSchoolItem = true;
            targets[i].isHospitalItem = true;
            targets[i].isCityHallItem = true;
            targets[i].isMuseumItem = true;

            yield return null;
        }

        Debug.Log("Finished load data");
    }

    #region Durable
    public int GetQttDur(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return 10;
            case 1:
                return 61;
            case 2:
                return 2;
            case 3:
                return 72;
            case 4:
                return 3;
            case 5:
                return 10;
            case 6:
                return 10;
            case 7:
                return 10;
            case 8:
                return 15;
            case 9:
                return 10;
            case 10:
                return 10;
            case 11:
                return 185;
            case 12:
                return 10;
            case 13:
                return 2;
            case 14:
                return 5;
            case 15:
                return 15;
            case 16:
                return 157;
            case 17:
                return 3;
            case 18:
                return 2;
            case 19:
                return 3;
            case 20:
                return 200;
            case 21:
                return 1;
            case 22:
                return 3;
            case 23:
                return 10;
            case 24:
                return 3;
            case 25:
                return 20;
            case 26:
                return 5;
            case 27:
                return 1;
            case 28:
                return 1;
            default:
                return 0;
        }
    }

    public float GetCostDur(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return 1615.02f;
            case 1:
                return 305.00f;
            case 2:
                return 1591.22f;
            case 3:
                return 219.00f;
            case 4:
                return 1655.70f;
            case 5:
                return 580.00f;
            case 6:
                return 140.00f;
            case 7:
                return 3834.05f;
            case 8:
                return 1387.49f;
            case 9:
                return 471.07f;
            case 10:
                return 1434.55f;
            case 11:
                return 610.00f;
            case 12:
                return 2898.10f;
            case 13:
                return 3741.09f;
            case 14:
                return 892.63f;
            case 15:
                return 841.12f;
            case 16:
                return 557.70f;
            case 17:
                return 1350.00f;
            case 18:
                return 2198.59f;
            case 19:
                return 1368.77f;
            case 20:
                return 210.00f;
            case 21:
                return 6500.00f;
            case 22:
                return 15597.00f;
            case 23:
                return 6100.00f;
            case 24:
                return 7244.00f;
            case 25:
                return 5877.09f;
            case 26:
                return 79990.00f;
            case 27:
                return 300000.00f;
            case 28:
                return 200000.00f;
            default:
                return 0f;
        }
    }

    public string GetDescriptionDur(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return "QUADRO BRANCO QUADRICULADO MEDINDO 450 CM X 120 CM";
            case 1:
                return "ITEM 01 CADEIRAS PARA COPA(CA1) - ESPECIFICA��ES COMPLETAS VIDE ITEM 2.1.1 DO ANEXO I - TERMO DE REFER�NCIA.RESUMO DAS ESPECIFICA��ES: CADEIRA FIXA COM ESTRUTURA EM A�O CROMADO, APOIO DE BRA�OS FIXO, ENCOSTO E ASSENTO EM POLIPROPILENO NA COR BRANCA.";
            case 2:
                return "2,00000 Unidade POLTRONA Poltrona, poltrona escrit�rio MARCA: FLEXFORM ITEM DO PROCESSO: 00022 ITEM DE MATERIAL: 000150664";
            case 3:
                return "MESA, TIPO ESCRIVANINHA, MEDINDO 0,80 X 0,75 X 0,50.";
            case 4:
                return "ARM�RIO PARA ESCRIT�RIO: Material MDF com PVC flex�vel e rod�zio; Cor creme com 2 portas e m�nimo 2 prateleiras internas; Fechadura com chave; Altura 165 cm; Largura 90 cm; Profundidade 45 cm";
            case 5:
                return "MACA CL�NICA, MATERIAL A�O INOXID�VEL, ACABAMENTO DA SUPERF�CIE ESMALTADO, RODAS SEM ROD�ZIOS, P�S FIXO, COMPRIMENTO AT� 2,00 M, LARGURA CERCA DE 0,90 M, ALTURA CERCA DE 1,00 M, CAPACIDADE DE CARGA AT� 250 KG, COMPONENTES C/ SUPORTE PARA LEN�OL DESCART�VEL, CARACTER�STICAS ADICIONAIS CABECEIRA REGUL�VEL POR CREMALHEIRA, ACESS�RIOS LEITO FIXO C/ COLCH�O, COURVIN";
            case 6:
                return "ESCADA HOSPITALAR, USO MACA, MATERIAL A�O INOXID�VEL, N�MERO DEGRAUS 2, REVESTIMENTO DEGRAUS TAPETE ANTIDERRAPANTE, TIPO DEGRAUS FIXO, COR BRANCA";
            case 7:
                return "APARELHO AR CONDICIONADO, CAPACIDADE REFRIGERA��O 24.000 BTU/H, TENS�O 220 V, TIPO SPLIT, MODELO PAREDE, CARACTER�STICAS ADICIONAIS COM CONTROLE REMOTO SEM FIO";
            case 8:
                return "REFRIGERADOR: com capacidade m�nima de 300l; Cor Branca; Sistema Frost Free; controle de temperatura que pode ser regulado; Compartimento Extra frio; M�nimo 2 prateleiras; Voltagem: 110V";
            case 9:
                return "FORNO MICRO-ONDAS: Especifica��es t�cnicas m�nimas: capacidade m�nima de 30l; fun��es de descongelamento e descongelamento de pratos prontos; prato girat�rio; trava de seguran�a; alarme sonoro; cor branca; Mensagens no �display� em portugu�s; Selo do Inmetro; Classifica��o de energia econ�mica; Voltagem: 110V.";
            case 10:
                return "BEBEDOURO DE PRESS�O: na cor Inox; Com acionamento el�trico por meio de bot�es laterais e frontais de livre toque e indica��o em Braile; Fixado na parede; Serve �gua natural e gelada; Bivolt:";
            case 11:
                return "BEBEDOURO �GUA GARRAF�O, MATERIAL A�O INOXID�VEL, TIPO EL�TRICO DE COLUNA, CAPACIDADE 20 L, VOLTAGEM 110 V, CARACTER�STICAS ADICIONAIS G�S ECOL�GICO/2 TORNEIRAS(�GUA NATURAL/GELADA)SE R";
            case 12:
                return "VENTILADOR: coluna/pedestal; escrit�rio/residencial; 200w; 1000 RPM a 1450 RPM; 110v; 0.2Kw/H; oscilante; controle velocidade; regulagem altura: m�nimo de 50cm";
            case 13:
                return "CAIXA DE SOM ATIVA: 2 Vias ativas; 200 Watts 8 OHMS; 1 Falante de 12; 1 Driver tit�nio; Entrada USB; Entrada para Microfone P10 XLR; Entrada RCA; Sa�da de Linha XLR; Sa�da para caixa passiva; AVS Sistema autom�tico de Voltagem; (110V e/ou bivolt); Dimens�es m�nimas (Altura 57,00 cm, Largura 39,0 cm e Profundidade 29,50 cm)";
            case 14:
                return "MESA DE SOM ANAL�GICA: 10 entradas.";
            case 15:
                return "MICROFONE SEM FIO(M�O) : Receptor Sistema PLL Multi-Frequ�ncias com 48 Canais Pr�-Definidos; - Display de Informa��es em LCD, Alcance de recep��o m�dia de 50m";
            case 16:
                return "APARELHO PURIFICADOR DE �GUA, TIPO DUPLA FILTRAGEM, VOLTAGEM 220 V, CAPACIDADE 2 L, VAZ�O 0,75 L/H, MATERIAL GABINETE MET�LICO/POLIPROPILENO, CAPACIDADE REFRIGERA��O 2,20 L/H, CARACTER�STICAS ADICIONAIS �GUA GELADA E �GUA NATURAL/ TUBO A�O INOXID�VEL/PO-, COR BRANCA";
            case 17:
                return "MULT�METRO, CARACTER�STICAS ADICIONAIS DISPLAY: 3 5/6 D�GITOS, 6000 CONTAGENS, ILUMINA��O, TIPO DIGITAL, TEMPERATURA 10 A 50�C OBSERVA��ES COMPLEMENTARES";
            case 18:
                return "TELEVISOR: com no m�nimo as seguintes caracter�sticas: Smart TV; 32 polegadas; LED; Resolu��o HD; 1 USB; 1 HDMI; Conversor Digital";
            case 19:
                return "MONITOR: com no m�nimo as seguintes caracter�sticas: Tipo LED; Tamanho da Tela: 19.5'; Formato de tela: 16:9 (widescreen).";
            case 20:
                return "ESTETOSC�PIO, TIPO BIAURICULAR, ACESS�RIOS OLIVAS ANAT�MICAS SILICONE, HASTE HASTE A�O INOX, TUBO TUBO 'Y' SILICONE, AUSCULTADOR AUSCULTADOR A�O INOX C/ ANEL DE BORRACHA, TAMANHO PEDI�TRICO";
            case 21:
                return "CARRETA RODOVI�RIA PARA TRANSPORTE DE BARCOS DE 05 A 06 METROS.CHASSI FABRICADO EM A�O GALVANIZADO A FOGO, COR CINZA, COM BER�O REGUL�VEL, TIPO ENGATE FIXA��O AUTOM�TICA E TRAVA DE SEGURAN�A, SISTEMA DE ILUMINA��O EM LED E A PROVA D �GUA E TRI�NGULO REFLETIVO.QUINCHO 1200 LBS, 544 KG COM CINTA DE 6 METROS.PRESEN�A DE ROLETES FACILITADORES COLOCA��O DO BARCO.PARA-CHOQUE EXPANS�VEL/REMOV�V EL C/ ILUMINA��O.";
            case 22:
                return "APARELHO RAIOS X, POT�NCIA APARELHO 50 A 125 KV, TIPO APARELHO M�VEL, C/ AMPOLAS DE RAIO X, APLICA��O USO M�DICO, TENS�O ALIMENTA��O 220 V, FREQU�NCIA 60 HZ, CARACTER�STICAS ADICIONAIS GERADOR ALTA FREQU�NCIA, CONTROLE DE KV E MAS, AC I, ADICIONAIS C/DESCARGA TEMPO CAPACITOR,C/ 300 MAS";
            case 23:
                return "DESFIBRILADOR, TIPO EXTERNO AUTOM�TICO, RECURSOS INTEGRADOS MONITOR ECG, TIPO ONDA BIF�SICA, TEMPO M�XIMO CARGA AT� 10 S, MEM�RIA GRAVA ECG,EVENTOS,SOM AMBIENTE, ALIMENTA��O BATERIA L�TIO, CAPACIDADE BATERIA M�NIMO DE 200 DESCARGAS, COMPONENTE P�S ADESIVAS DESCART�VEIS, COMPONENTES ADICIONAIS TECLA C/ MENSAGEM DE TEXTO, CARACTER�STICAS ADICIONAIS COMANDO DE VOZ, TIPO M�DULO PORT�TIL, C/ AL�A TRANSPORTE, MALETA";
            case 24:
                return "DESUMIDIFICADOR PORT�TIL: autom�tico; com al�as laterais e rod�zios para facilitar a mobilidade; com umidostato para regulagem da umidade do ambiente; recipiente coletor de �gua com, no m�nimo, 3 (tr�s litros de capacidade); adaptador para mangueira; chave de liga/desliga; com parada autom�tica quando o reservat�rio de �gua atingir o n�vel m�ximo e luz indicativa de reservat�rio cheio; capacidade para desumidificar ambientes de, no m�nimo, 150m�; capacidade de condensa��o(24h) de, no m�nimo, 10 litros de �gua; tens�o/voltagem: 127V/60Hz";
            case 25:
                return "MICROCOMPUTADOR: com no m�nimo as seguintes caracter�sticas: Processador com 3,0 GHZ; Mem�ria Ram 8GB; Placa de v�deo 4GB, 128 bits; Disco R�gido de 1TB de armazenamento";
            case 26:
                return "DISPOSITIVO ARMAZENAMENTO FITA, CAPACIDADE ARMAZENAMENTO 48, VELOCIDADE TRANSFER�NCIA 10.8 TB/H, COMPATIBILIDADE LTO-5, LTO-6, LTO7 E LTO-8, INTERFACE SAS, ALIMENTA��O 127/240 V";
            case 27:
                return "O porta-estandarte, 1946 de Robert Gwthamey doado por Nelson Rockefeller";
            case 28: 
                return "A aula,  1946 de Jacob Lawrence doado por Nelson Rockefeller";


            default:
                return "";
        }
    }

    public string GetItemNameDur(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return "QUADRO BRANCO 450CM X 120CM";
            case 1:
                return "CADEIRA";
            case 2:
                return "POLTRONA";
            case 3:
                return "ESCRIVANINHA";
            case 4:
                return "ARM�RIO PARA ESCRIT�RIO";
            case 5:
                return "MACA CL�NICA";
            case 6:
                return "ESCADA HOSPITALAR";
            case 7:
                return "APARELHO AR CONDICIONADO";
            case 8:
                return "REFRIGERADOR";
            case 9:
                return "FORNO MICRO-ONDAS";
            case 10:
                return "BEBEDOURO DE PRESS�O";
            case 11:
                return "BEBEDOURO �GUA GARRAF�O";
            case 12:
                return "VENTILADOR";
            case 13:
                return "CAIXA DE SOM ATIVA";
            case 14:
                return "MESA DE SOM ANAL�GICA";
            case 15:
                return "MICROFONE SEM FIO(M�O)";
            case 16:
                return "APARELHO PURIFICADOR DE �GUA";
            case 17:
                return "MULT�METRO";
            case 18:
                return "TELEVISOR 32";
            case 19:
                return "MONITOR";
            case 20:
                return "ESTETOSC�PIO";
            case 21:
                return "CARRETA TRANSPORTE EMBARCA��O";
            case 22:
                return "APARELHO RAIOS X M�VEL";
            case 23:
                return "DESFIBRILADOR";
            case 24:
                return "DESUMIDIFICADOR PORT�TIL 3L";
            case 25:
                return "MICROCOMPUTADOR";
            case 26:
                return "DISPOSITIVO ARMAZENAMENTO FITA 10.8 TB";
            case 27:
                return "Obra de Arte �leo sobre tela 86,5 cm x 61,6 cm";
            case 28:
                return "Obra de Arte aquarela sobre papel 55,4 cm x 76,4 cm";

            default:
                return "";
        }
    }

    #endregion Durable

    #region Consumable
    public IEnumerator LoadConsumables()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].itemQuantity = GetQtt(i);
            targets[i].itemCost = GetCost(i);
            targets[i].itemDescription = GetDescription(i);
            targets[i].itemName = GetItemName(i);

            yield return null;
        }

        Debug.Log("Finished load data");
    }

    public int GetQtt(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return 30;
            case 1:
                return 16;
            case 2:
                return 2040;
            case 3:
                return 3552;
            case 4:
                return 25000;
            case 5:
                return 442;
            case 6:
                return 25;
            case 7:
                return 48;
            case 8:
                return 225;
            case 9:
                return 170;
            case 10:
                return 50;
            case 11:
                return 50;
            case 12:
                return 50;
            case 13:
                return 100;
            case 14:
                return 30;
            case 15:
                return 10;
            case 16:
                return 50;
            case 17:
                return 50;
            case 18:
                return 100;
            case 19:
                return 20;
            case 20:
                return 80;
            case 21:
                return 1200;
            case 22:
                return 7000;
            case 23:
                return 626;
            case 24:
                return 3000;
            case 25:
                return 500;
            case 26:
                return 1000;
            case 27:
                return 723;
            case 28:
                return 582;
            case 29:
                return 10;
            case 30:
                return 1;
            case 31:
                return 1;
            case 32:
                return 440;
            case 33:
                return 55;
            case 34:
                return 2;
            case 35:
                return 4;
            case 36:
                return 165;
            case 37:
                return 650;
            case 38:
                return 427;
            case 39:
                return 65;
            case 40:
                return 178;
            case 41:
                return 750;
            case 42:
                return 595;
            case 43:
                return 24;
            case 44:
                return 54;
            case 45:
                return 150;
            case 46:
                return 8337;
            case 47:
                return 3766;
            case 48:
                return 2275;
            case 49:
                return 100;
            case 50:
                return 10;
            case 51:
                return 769;
            case 52:
                return 291;
            case 53:
                return 290;
            case 54:
                return 366;
            case 55:
                return 7;
            case 56:
                return 300;
            case 57:
                return 287;
            case 58:
                return 30;
            case 59:
                return 115;
            case 60:
                return 10;
            case 61:
                return 112;
            case 62:
                return 3;
            case 63:
                return 60;
            case 64:
                return 50;
            case 65:
                return 50;
            case 66:
                return 150;
            case 67:
                return 352;
            case 68:
                return 50;
            case 69:
                return 350;
            case 70:
                return 670;
            case 71:
                return 925;
            case 72:
                return 15;
            case 73:
                return 5;
            case 74:
                return 9;
            case 75:
                return 20;
            case 76:
                return 301;
            case 77:
                return 70;
            case 78:
                return 336;
            case 79:
                return 3;
            case 80:
                return 52;
            case 81:
                return 192;
            case 82:
                return 371;
            case 83:
                return 5;
            case 84:
                return 13;
            case 85:
                return 56;
            case 86:
                return 5;
            case 87:
                return 50;
            case 88:
                return 102;
            case 89:
                return 144;
            case 90:
                return 86;
            case 91:
                return 1;
            case 92:
                return 1;
            default:
                return 0; // or any other default value you want
        }
    }

    public float GetCost(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return 55.71f;
            case 1:
                return 58.98f;
            case 2:
                return 14.79f;
            case 3:
                return 8.99f;
            case 4:
                return 0.02f;
            case 5:
                return 6.07f;
            case 6:
                return 16.38f;
            case 7:
                return 2.47f;
            case 8:
                return 5.00f;
            case 9:
                return 99.23f;
            case 10:
                return 0.86f;
            case 11:
                return 1.00f;
            case 12:
                return 1.90f;
            case 13:
                return 6.78f;
            case 14:
                return 2.50f;
            case 15:
                return 13.30f;
            case 16:
                return 1.80f;
            case 17:
                return 44.07f;
            case 18:
                return 1.00f;
            case 19:
                return 7.00f;
            case 20:
                return 135.20f;
            case 21:
                return 770f;
            case 22:
                return 18.19f;
            case 23:
                return 39.3f;
            case 24:
                return 21.9f;
            case 25:
                return 158.9f;
            case 26:
                return 24.85f;
            case 27:
                return 5.0f;
            case 28:
                return 7.0f;
            case 29:
                return 5.85f;
            case 30:
                return 210.00f;
            case 31:
                return 9.56f;
            case 32:
                return 28.00f;
            case 33:
                return 44.00f;
            case 34:
                return 22.49f;
            case 35:
                return 3.03f;
            case 36:
                return 5.11f;
            case 37:
                return 3.88f;
            case 38:
                return 0.87f;
            case 39:
                return 5.73f;
            case 40:
                return 4.80f;
            case 41:
                return 2.50f;
            case 42:
                return 1.80f;
            case 43:
                return 3.39f;
            case 44:
                return 12.96f;
            case 45:
                return 4.08f;
            case 46:
                return 0.48f;
            case 47:
                return 0.45f;
            case 48:
                return 0.48f;
            case 49:
                return 6.36f;
            case 50:
                return 2.33f;
            case 51:
                return 1.05f;
            case 52:
                return 1.03f;
            case 53:
                return 1.00f;
            case 54:
                return 01.04f;
            case 55:
                return 14.05f;
            case 56:
                return 0.55f;
            case 57:
                return 21.15f;
            case 58:
                return 2.06f;
            case 59:
                return 11.11f;
            case 60:
                return 232.00f;
            case 61:
                return 1.80f;
            case 62:
                return 11.98f;
            case 63:
                return 28.35f;
            case 64:
                return 23.24f;
            case 65:
                return 27.12f;
            case 66:
                return 4.08f;
            case 67:
                return 4.12f;
            case 68:
                return 34.82f;
            case 69:
                return 0.29f;
            case 70:
                return 0.92f;
            case 71:
                return 1.25f;
            case 72:
                return 2.39f;
            case 73:
                return 2.76f;
            case 74:
                return 3.73f;
            case 75:
                return 3.66f;
            case 76:
                return 1.82f;
            case 77:
                return 1.87f;
            case 78:
                return 52.04f;
            case 79:
                return 187.92f;
            case 80:
                return 68.54f;
            case 81:
                return 18.39f;
            case 82:
                return 31.66f;
            case 83:
                return 43.75f;
            case 84:
                return 18.98f;
            case 85:
                return 60.34f;
            case 86:
                return 48.00f;
            case 87:
                return 10.33f;
            case 88:
                return 2.45f;
            case 89:
                return 7.21f;
            case 90:
                return 4.92f;
            case 91:
                return 226.28f;
            case 92:
                return 106.47f;
            default:
                return 0f;

        }
    }

    public string GetDescription(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return "A�UCAREIRO, MATERIAL A�O INOXID�VEL, CAPACIDADE 300 G, CARACTER�STICAS ADICIONAIS COM TAMPA, COM P� PARA A��CAR, FORMATO OVALOBSERVA��ES COMPLEMENTARES.";
            case 1:
                return "CAF�, APRESENTA��O TORRADO EM GR�O, INTENSIDADE M�DIA, TIPO TRADICIONAL";
            case 2:
                return "CAF�, APRESENTA��O TORRADO MO�DO, INTENSIDADE SUAVE, TIPO TRADICIONAL, EMPACOTAMENTO V�CUO";
            case 3:
                return "�GUA MINERAL NATURAL, TIPO SEM G�S, MATERIAL EMBALAGEM PL�STICO, TIPO EMBALAGEM RETORN�VEL";
            case 4:
                return "ADO�ANTE, ASPECTO F�SICO L�QUIDO, INGREDIENTES EST�VIA, TIPO DIET�TICO MARCA: STEVITA ITEM DO PROCESSO: 00004 ITEM DE MATERIAL: 000236197";
            case 5:
                return "COPO DESCART�VEL, MATERIAL POLIPROPILENO, CAPACIDADE 200 ML, APLICA��O L�QUIDOS FRIOS E QUENTES, CARACTER�STICAS ADICIONAIS AT�XICO, DE ACORDO C/ NORMA ABNT, NBR 14865, COR BRANCO";
            case 6:
                return "ADO�ANTE, ASPECTO F�SICO L�QUIDO, INGREDIENTES EST�VIA, TIPO DIET�TICO MARCA: STEVITA ITEM DO PROCESSO: 00004 ITEM DE MATERIAL: 000236197";
            case 7:
                return "COADOR DESCART�VEL CAF�, MATERIAL PAPEL, TAMANHO 102 MARCA: MALU ITEM DO PROCESSO: 00019 ITEM DE MATERIAL: 000237589";
            case 8:
                return "CANETA ROMA EM PL�STICO, ESFEROGR�FICA, COM ARTE, CONFORME SOLICITANTE.";
            case 9:
                return "CLIPE USO CIR�RGICO, MAT�RIA PRIMA TIT�NIO, APLICA��O* HEMOST�TICO, TAMANHO* M�DIO- LARGO, ESTERILIDADE* EST�RIL, DESCART�VEL";
            case 10:
                return "BORRACHA BRANCA 20 CX/20 UND LEOELEO";
            case 11:
                return "CANETAS E MARCADORES, COM PONTA DE FELTRO OU COM OUTRAS PONTAS POROSAS";
            case 12:
                return "MOLAS PARA PAP�IS, OUTROS OBJETOS DE ESCRIT�RIO, DE METAIS COMUNS";
            case 13:
                return "OUTROS ARTIGOS SEMELHANTES A CAIXAS, ENGRADADOS, ETC, DE PL�STICO";
            case 14:
                return "OUTROS PRODUTOS DE QUALQUER ESP�CIE UTILIZADOS COMO COLAS OU ADESIVOS, ACONDICIONADOS PARA VENDA A RETALHO COMO COLAS OU ADESIVOS, COM PESO L�QUIDO N�O SUPERIOR A 1 KG";
            case 15:
                return "OUTRAS OBRAS DE PL�STICOS";
            case 16:
                return "MOLAS PARA PAP�IS, OUTROS OBJETOS DE ESCRIT�RIO, DE METAIS COMUNS";
            case 17:
                return "SERINGA, MATERIAL VIDRO, CAPACIDADE 10 ML, TIPO BICO BICO CENTRAL LUER LOCK OUSLIP, ADICIONAL GRADUADA, NUMERADA, ESTERILIDADE ESTERILIZ�VEL";
            case 18:
                return "FRASCO 10,00 ML CLORETO DE S�DIO, CONCENTRA�AO 0,9 , FORMA FARMACEUTICA SOLU��O EST�RIL N�O INJET�VEL";
            case 19:
                return "ROLO 10,00 M FITA HOSPITALAR, TIPO MICROPOROSA, MATERIAL DORSO EM N�O TECIDO, COMPONENTES ADESIVO ACR�LICO, DIMENS�ES CERCA DE 25 MM, CARACTER�STICAS ADICIONAIS HIPOALERG�NICO, COR COM COR";
            case 20:
                return "ATADURA GESSADA, MATERIAL TELA TIPO GIRO INGL�S, 100% ALGOD�O, LARGURA 10 CM, COMPRIMENTO 300 CM, CARACTER�STICAS ADICIONAIS IMPREGNADA C/GESSO COLOIDAL, SECAGEM ULTRA R�PIDA";
            case 21:
                return "COLETOR MATERIAL P�RFURO-CORTANTE, MATERIAL PAPEL�O, CAPACIDADE TOTAL 13 L, ACESS�RIOS AL�AS R�GIDAS E TAMPA, COMPONENTES ADICIONAIS REVESTIMENTO INTERNO EM POLIETILENO ALTA DENSIDAD E, TIPO USO DESCART�VEL";
            case 22:
                return "UNIFORMES, TECIDOS E AVIAMENTOS";
            case 23:
                return "LUVA PARA PROCEDIMENTO N�O CIR�RGICO, MATERIAL L�TEX NATURAL �NTEGRO E UNIFORME, TAMANHO PEQUENO, CARACTER�STICAS ADICIONAIS LUBRIFICADA COM P� BIOABSORV�VEL, DESCART�VEL, APRESENTA��O AT�XICA, TIPO AMBIDESTRA, TIPO USO DESCART�VEL, MODELO FORMATO ANAT�MICO, FINALIDADE RESISTENTE � TRA��O";
            case 24:
                return "�LCOOL ET�LICO, TIPO HIDRATADO, TEOR ALCO�LICO 70%_(70 GL), APRESENTA��O GEL";
            case 25:
                return "M�SCARA CIR�RGICA, TIPO N�O TECIDO,3 CAMADAS,PREGAS HORIZONTAIS, AT�XICA, TIPO FIXA��O COM EL�STICO, CARACTER�STICAS ADICIONAIS CLIP NASAL EMBUTIDO,HIPOALERG�NICA, TIPO USO DESCART�VEL";
            case 26:
                return "M�SCARA, TIPO RESPIRADOR, TIPO FIXA��O DUPLO SISTEMA DE TIRAS EL�STICAS, APLICA��O FILTRAGEM BACTERIANA 99%, TAMANHO REGULAR, CARACTER�STICAS ADICIONAIS CLASSE PFF2(POEIRAS, FUMOS, N�VOAS T�XICAS), FORMATO EM CONCHA, DUPLA CAMADA";
            case 27:
                return "TOALHA DE PAPEL, TOALHA PAPEL - MAO";
            case 28:
                return "SABONETE L�QUIDO, ASPECTO F�SICO L�QUIDO CREMOSO PEROLADO, COR BRANCA, ACIDEZ NEUTRO PH, APLICA��O COMERCIAL";
            case 29:
                return "FITA HOSPITALAR, TIPO ESPARADRAPO, IMPERME�VEL, MATERIAL ALGOD�O, COMPONENTES ADESIVO � BASE DE ZINCO, DIMENS�ES CERCA DE 10 CM, CARACTER�STICAS ADICIONAIS HIPOALERG�NICO, COR COM COR";
            case 30:
                return "ESTETOSC�PIO, TIPO BIAURICULAR, ACESS�RIOS OLIVAS ANAT�MICAS SILICONE, HASTE HASTE A�O INOX, TUBO TUBO Y SILICONE, AUSCULTADOR AUSCULTADOR A�O INOX C/ ANEL DE BORRACHA, TAMANHO PEDI�TRICO";
            case 31:
                return "LANCETA, MATERIAL L�MINA A�O INOXID�VEL, PONTA AFIADA,TRIFACETADA, USO DESCART�VEL, CARACTER�STICAS ADICIONAIS EST�RIL, EMBALAGEM INDIVIDUAL, TIPO COM SISTEMA RETR�TIL";
            case 32:
                return "MOLDURAS: para diplomas de honrarias, confeccionada em madeira 4,5 cm de largura, cor dourada com fundo em MDF, pendurador tri�ngulo horizontal, prendedores flex point, vidro antireflexo, tamanho 21 x 30 cm";
            case 33:
                return "MOLDURAS: para diplomas de honrarias, confeccionada em madeira 4,5 cm de largura, cor dourada com fundo em MDF, pendurador tri�ngulo horizontal, prendedores flex point, vidro antireflexo, tamanho 42 x 30 cm";
            case 34:
                return "AGENDA";
            case 35:
                return "ALFINETE MAPA, MATERIAL METAL, TRATAMENTO SUPERFICIAL GALVANIZADO, MATERIAL CABE�A PL�STICO, FORMATO CABE�A REDONDO, COR AZUL, COMPRIMENTO 15 MM, APLICA��O MAPA";
            case 36:
                return "ALMOFADA CARIMBO, MATERIAL CAIXA PL�STICO/METAL, MATERIAL ALMOFADA ESPONJA ABSORVENTE REVESTIDA DE TECIDO, TAMANHO GRANDE, COR AZUL, TIPO ENTINTADA";
            case 37:
                return "APAGADOR QUADRO BRANCO, MATERIAL BASE FELTRO, MATERIAL CORPO PL�STICO, COMPRIMENTO 15 CM, LARGURA 6 CM, ALTURA 5 CM";
            case 38:
                return "APONTADOR L�PIS, MATERIAL METAL E PL�STICO, TIPO ESCOLAR, CARACTER�STICAS ADICIONAIS COM DEP�SITO";
            case 39:
                return "BARBANTE, MATERIAL R�FIA, COR BRANCA, CARACTER�STICAS ADICIONAIS FIBRA NATURAL.";
            case 40:
                return "BARBANTE ALGOD�O";
            case 41:
                return "BLOCO RECADO, MATERIAL PAPEL, COR AMARELO, LARGURA 38 MM, COMPRIMENTO 50 MM, TIPO REMOV�VEL, CARACTER�STICAS ADICIONAIS AUTO-ADESIVO";
            case 42:
                return "BLOCO RECADO, MATERIAL PAPEL, COR AMARELA, LARGURA 76 MM, COMPRIMENTO 76 MM, CARACTER�STICAS ADICIONAIS AUTO-ADESIVO, POST IT, QUANTIDADE FOLHAS 100 UN";
            case 43:
                return "BOBINA PAPEL SENHA, MATERIAL PAPEL T�RMICO, LARGURA 79 MM, COMPRIMENTO 40 M, APLICA��O IMPRESSORA GERENCIADORA DE FILA, CARACTER�STICAS ADICIONAIS DI�METRO 60MM E TUBETE 12MM";
            case 44:
                return "BORRACHA APAGADORA ESCRITA, MATERIAL BORRACHA, COMPRIMENTO 50 MM, LARGURA 18 MM, ALTURA 6 MM, COR AZUL E VERMELHA, APLICA��O PARA L�PIS E TINTA";
            case 45:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, MATERIAL CAPA PAPEL�O, APRESENTA��O BROCHURA, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 210 MM, LARGURA 150 MM";
            case 46:
                return "CANETA ESFEROGR�FICA, MATERIAL PL�STICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LAT�O COM ESFERA DE TUNGST�NIO, TIPO ESCRITA M�DIA, COR TINTA AZUL, CARACTER�STICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIF�CIO LATERAL";
            case 47:
                return "CANETA ESFEROGR�FICA, MATERIAL PL�STICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LAT�O COM ESFERA DE TUNGST�NIO, TIPO ESCRITA M�DIA, COR TINTA PRETA, CARACTER�STICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIF�CIO LATERAL";
            case 48:
                return "CANETA ESFEROGR�FICA, MATERIAL PL�STICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LAT�O COM ESFERA DE TUNGST�NIO, TIPO ESCRITA M�DIA, COR TINTA VERMELHA, CARACTER�STICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIF�CIO LATERAL";
            case 49:
                return "CANETA HIDROGR�FICA, MATERIAL PL�STICO, MATERIAL PONTA FELTRO, APLICA��O PAPEL, CARACTER�STICAS ADICIONAIS JUMBO 12 CORES E ESTOJO COM ZIP.";
            case 50:
                return "PINCEL MARCADOR PERMANENTE CD, MATERIAL PL�STICO, TIPO PONTA FELTRO, COR TINTA AZUL";
            case 51:
                return "CANETA MARCA-TEXTO, MATERIAL PL�STICO, TIPO PONTA CHANFRADA, COR FLUORESCENTE AMARELA, CARACTER�STICAS ADICIONAIS TRA�O 4 MM";
            case 52:
                return "CANETA MARCA-TEXTO, MATERIAL PL�STICO, TIPO PONTA FLUORESCENTE, COR LARANJA";
            case 53:
                return "CANETA MARCA-TEXTO, MATERIAL PL�STICO, TIPO PONTA FLUORESCENTE, COR ROSA";
            case 54:
                return "CANETA MARCA-TEXTO, MATERIAL PL�STICO, TIPO PONTA FLUORESCENTE, COR VERDE.";
            case 55:
                return "CANETA DESENHO ARQUITET�NICO, MATERIAL CORPO PL�STICO, MATERIAL PONTA METAL, CARACTER�STICAS ADICIONAIS TINTA:NANQUIM/ USO:DESCARTAVEL, TAMANHO PONTA 0,30 MM, COR PRETA";
            case 56:
                return "CARTOLINA, MATERIAL CELULOSE VEGETAL, GRAMATURA 150 G/M2, COMPRIMENTO 660 MM, LARGURA 500 MM, COR AZUL";
            case 57:
                return "GRAMPEADOR, MATERIAL METAL, TIPO MESA, CAPACIDADE 25 FL, TAMANHO GRAMPO 26/6, CARACTER�STICAS ADICIONAIS BASE DE BORRACHA";
            case 58:
                return "L�PIS BORRACHA, MATERIAL MADEIRA, DI�METRO CARGA 4 MM, FORMATO CORPO CIL�NDRICO, DI�METRO CORPO 8 MM, COMPRIMENTO TOTAL 175 MM, APLICA��O TINTA/ GRAFITE";
            case 59:
                return "LIVRO PROTOCOLO, MATERIAL PAPEL OFF-SET, QUANTIDADE FOLHAS 100 FL, COMPRIMENTO 230 MM, LARGURA 170 MM, TIPO CAPA DURA, CARACTER�STICAS ADICIONAIS COM FOLHAS PAUTADAS E NUMERADAS SEQ�ENCIALMENTE, MATERIAL CAPA PAPEL�O, GRAMATURA FOLHAS 54 G/M2";
            case 60:
                return "LUPA, TIPO PORT�TIL, FORMATO REDONDA, FAIXA AMPLIA��O M�NIMO 10 VEZES, DI�METRO 6 CM, MATERIAL CABO METAL, CARACTER�STICAS ADICIONAIS REGUL�VEL E ARTICULADO, DE MESA";
            case 61:
                return "MOLHA-DEDOS, MATERIAL BASE PL�STICO, MATERIAL TAMPA PL�STICO, MATERIAL CARGA MASSA, TAMANHO 12, VALIDADE CARGA 1 ANO, CARACTER�STICAS ADICIONAIS CONT�M GLICERINA E N�O MANCHA";
            case 62:
                return "PUN��O - ESCRITA BRAILE, MATERIAL CABO PL�STICO, MATERIAL PONTEIRA A�O, FORMATO ESF�RICO, DI�METRO 25 MM";
            case 63:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 60 CM, LARGURA 45 CM , USO ART�STICO";
            case 64:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 50 CM, LARGURA 35 CM , USO ART�STICO";
            case 65:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 60 CM, LARGURA 60 CM , USO ART�STICO";
            case 66:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, MATERIAL CAPA PAPEL�O, APRESENTA��O BROCHURA, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 210 MM, LARGURA 150 MM";
            case 67:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, APRESENTA��O ESPIRAL, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 202 MM, LARGURA 140 MM, CARACTER�STICAS ADICIONAIS FOLHA PAUTADA E CAPA DURA";
            case 68:
                return "CALCULADORA ELETR�NICA, NOME CALCULADORA ELETR�NICA";
            case 69:
                return "CAPA ENCADERNA��O, MATERIAL PVC- CLORETO DE POLIVINILA, TIPO A4, COR INCOLOR, FORMATO 210 X 297 MM, LOMBADA 5 MM, CARACTER�STICAS ADICIONAIS LONG STEELCRYSTAL";
            case 70:
                return "CHAVEIRO, MATERIAL PL�STICO, FORMATO RETANGULAR, TAMANHO 5,8 X 2,60 X 0,5 CM, COR SORTIDA, APLICA��O IDENTIFICA��O CHAVES, CARACTER�STICAS ADICIONAIS TIPO CAIXA, ETIQUETA INTERNA DE PAPEL";
            case 71:
                return "COLA, COR BRANCA, APLICA��O PAPEL, CARACTER�STICAS ADICIONAIS INSTANT�NEA, TIPO L�QUIDO";
            case 72:
                return "COLCHETE FIXA��O, MATERIAL A�O, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO N� 3";
            case 73:
                return "COLCHETE FIXA��O, MATERIAL A�O, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO N� 5";
            case 74:
                return "COLCHETE FIXA��O, MATERIAL A�O, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO N� 6";
            case 75:
                return "COLCHETE FIXA��O, MATERIAL A�O, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO N� 7";
            case 76:
                return "CORRETIVO L�QUIDO, MATERIAL BASE D'�GUA- SECAGEM R�PIDA, APRESENTA��O FRASCO, APLICA��O PAPEL COMUM ML, VOLUME 18 ML";
            case 77:
                return "CINTA EL�STICA, MATERIAL BORRACHA, FORMA CIRCULAR, COR NATURAL, APLICA��O ORGANIZA��O MATERIAL EXPEDIENTE";
            case 78:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 340 MM, COR PARDA, LARGURA 240 MM";
            case 79:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 242 MM, COR PARDA, LARGURA 336 MM";
            case 80:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 360 MM, COR PARDA, IMPRESS�O BAIXO-RELEVO, LARGURA 260 MM";
            case 81:
                return "ENVELOPE PL�STICO, COMPRIMENTO 32 CM, LARGURA 24 CM, CARACTER�STICAS ADICIONAIS COM 4 FUROS, APLICA��O PASTA CAT�LOGO, MATERIAL PL�STICO";
            case 82:
                return "ENVELOPE PL�STICO, TIPO PL�STICO POLIETILENO ALTA TRANSPAR�NCIA, COMPRIMENTO 316 MM, LARGURA 240 MM, COR BRANCA, CARACTER�STICAS ADICIONAIS SEM FUROS, TIPO SACO, APLICA��O ACONDICIONAMENTO DE DOCUMENTOS, GRAMATURA 80 G/M2";
            case 83:
                return "ESCAL�METRO, MATERIAL PL�STICO, TIPO ESCALA TRIPLO DEC�METRO, TAMANHO 30 CM, ESCALA GRADUA��O 1:20, 1:25, 1:50, 1:75, 1:100 E 1:125";
            case 84:
                return "ETIQUETA ADESIVA, MATERIAL PAPEL, COR BRANCA, LARGURA 60 MM, COMPRIMENTO 170 MM, TIPO AUTO-ADESIVA, CARACTER�STICAS ADICIONAIS FOLHA A4 C/ 4 ETIQUETAS";
            case 85:
                return "PAPEL AUTO-ADESIVO, MATERIAL PL�STICO, TIPO CONTACT, COR INCOLOR, GRAMATURA 60 G/M2, LARGURA 450 MM, ACABAMENTO SUPERFICIAL BRILHANTE, COMPRIMENTO FOLHA 2.500 MM, TRANSMIT�NCIA TRANSPARENTE";
            case 86:
                return "R�GUA GABARITO, MATERIAL ACR�LICO, APLICA��O DIAGRAMA��O, COR INCOLOR";
            case 87:
                return "GLITTER, MATERIAL PVC- CLORETO DE POLIVINILA, ASPECTO F�SICO PART�CULAS METALIZADAS, COR SORTIDA, APLICA��O DECORA��O/ROUPA/ARTESANATO/FANTASIA/FLOR E ISOPOR";
            case 88:
                return "GRAFITE, DI�METRO 0,50 MM";
            case 89:
                return "GRAFITE, DI�METRO 0,70 MM";
            case 90:
                return "GRAFITE, DI�METRO 0,90 MM";
            case 91:
                return "C�MERA WEBCAM HD 720P C/MICROFONE: V�DEO CHAMADA HD[1280 X 720 PIXELS] COM SI STEMA RECOMENDADO.CAPTURA DE V�DEO: AT� 1280 X 720 PIXELS.FOTOS: AT� 3,0 MEG APIXELS [COM OTIMIZA��O DO SOFTWARE]. MICROFONE EMBUTIDO COM A TECNOLOGIA RIGH TSOUND.USB 2.0 DE ALTA VELOCIDADE CERTIFICADO. CLIPE UNIVERSAL QUE SE AJUSTA A LAPTOPS, MONITORES LCD OU CRT.";
            case 92:
                return "OX�METRO USO M�DICO, TIPO DEDO, FAIXA MEDI��O SATURA��O 1 0 A 100%, FAIXA MEDI��O PULSO 1 CERCA DE 20 A 250 BPM, AUTONOMIA SISTEMA 1 CERCA 24 H, ALIMENTA��O PILHA, ACESS�RIOS C/ SENSOR";

            default:
                return "";
        }
    }

    public string GetItemName(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return "A�UCAREIRO";
            case 1:
                return "CAF� INTENSIDADE M�DIA";
            case 2:
                return "CAF� INTENSIDADE SUAVE";
            case 3:
                return "�GUA MINERAL NATURAL";
            case 4:
                return "ADO�ANTE";
            case 5:
                return "COPO DESCART�VEL";
            case 6:
                return "ADO�ANTE, ASPECTO F�SICO L�QUIDO";
            case 7:
                return "COADOR DESCART�VEL CAF�";
            case 8:
                return "CANETA ESFEROGR�FICA";
            case 9:
                return "CLIPE USO CIR�RGICO";
            case 10:
                return "BORRACHA BRANCA";
            case 11:
                return "MARCA TEXTO AMARELO MASTER PRIN";
            case 12:
                return "CLIPS 3/0 CX PEQUENA";
            case 13:
                return "CAIXA ARQUIVO MORTO DELLO";
            case 14:
                return "COLA BASTAO 40GRAMAS";
            case 15:
                return "PRANCHETA ACRILICO GARRA METAL";
            case 16:
                return "CLIPS 4/0 CX PEQUENA";
            case 17:
                return "SERINGA, MATERIAL VIDRO";
            case 18:
                return "CLORETO DE S�DIO";
            case 19:
                return "FITA HOSPITALAR, TIPO MICROPOROSA";
            case 20:
                return "ATADURA GESSADA";
            case 21:
                return "COLETOR MATERIAL P�RFURO-CORTANTE,";
            case 22:
                return "AVENTAL HOSPITALAR";
            case 23:
                return "LUVA PARA PROCEDIMENTO N�O CIR�RGICO";
            case 24:
                return "�LCOOL ET�LICO 70% GEL";
            case 25:
                return "M�SCARA CIR�RGICA";
            case 26:
                return "M�SCARA CIR�RGICA";
            case 27:
                return "TOALHA DE PAPEL";
            case 28:
                return "SABONETE L�QUIDO";
            case 29:
                return "FITA HOSPITALAR";
            case 30:
                return "ESTETOSC�PIO";
            case 31:
                return "LANCETA";
            case 32:
                return "MODURA 21X30 CM";
            case 33:
                return "MODURA 42X30 CM";
            case 34:
                return "AGENDA";
            case 35:
                return "ALFINETE MAPA AZUL";
            case 36:
                return "ALMOFADA CARIMBO AZUL";
            case 37:
                return "APAGADOR QUADRO BRANCO";
            case 38:
                return "APONTADOR L�PIS";
            case 39:
                return "BARBANTE";
            case 40:
                return "BARBANTE ALGOD�O";
            case 41:
                return "BLOCO RECADO 38 MM";
            case 42:
                return "BLOCO RECADO 76 MM";
            case 43:
                return "BOBINA PAPEL SENHA";
            case 44:
                return "BORRACHA APAGADORA ESCRITA";
            case 45:
                return "CADERNO";
            case 46:
                return "CANETA ESFEROGR�FICA  AZUL";
            case 47:
                return "CANETA ESFEROGR�FICA PRETA";
            case 48:
                return "CANETA ESFEROGR�FICA VERMELHA";
            case 49:
                return "CANETA HIDROGR�FICA";
            case 50:
                return "PINCEL MARCADOR AZUL PERMANENTE CD";
            case 51:
                return "CANETA MARCA-TEXTO AMARELA";
            case 52:
                return "CANETA MARCA-TEXT LARANJA";
            case 53:
                return "CANETA MARCA-TEXT ROSA";
            case 54:
                return "CANETA MARCA-TEXT VERDE";
            case 55:
                return "CANETA DESENHO ARQUITET�NICO";
            case 56:
                return "CARTOLINA AZUL";
            case 57:
                return "GRAMPEADOR";
            case 58:
                return "L�PIS BORRACHA";
            case 59:
                return "LIVRO PROTOCOLO";
            case 60:
                return "LUPA";
            case 61:
                return "MOLHA-DEDOS";
            case 62:
                return "PUN��O - ESCRITA BRAILE";
            case 63:
                return "TELA DE PINTURA 45X60";
            case 64:
                return "TELA DE PINTURA 35X50";
            case 65:
                return "TELA DE PINTURA 60X60";
            case 66:
                return "CADERNO, APRESENTA��O BROCHURA,";
            case 67:
                return "CADERNO, APRESENTA��O ESPIRAL";
            case 68:
                return "CALCULADORA ELETR�NICA";
            case 69:
                return "CAPA ENCADERNA��O";
            case 70:
                return "CHAVEIRO";
            case 71:
                return "COLA, COR BRANCA, TIPO L�QUIDO";
            case 72:
                return "COLCHETE FIXA��O N� 3";
            case 73:
                return "COLCHETE FIXA��O N� 5";
            case 74:
                return "COLCHETE FIXA��O N� 6";
            case 75:
                return "COLCHETE FIXA��O N� 7";
            case 76:
                return "CORRETIVO L�QUIDO";
            case 77:
                return "CINTA EL�STICA  100G";
            case 78:
                return "ENVELOPE 340 MM PO 240MM";
            case 79:
                return "ENVELOPE  242 MM POR 336MM";
            case 80:
                return "ENVELOPE  360 MM POR 260 MM";
            case 81:
                return "ENVELOPE PL�STICO, 32 CM,POR 24 CM,";
            case 82:
                return "ENVELOPE PL�STICO,316 MM, POR 240 MM";
            case 83:
                return "ESCAL�METRO";
            case 84:
                return "ETIQUETA ADESIVA";
            case 85:
                return "PAPEL AUTO-ADESIVO";
            case 86:
                return "R�GUA GABARITO";
            case 87:
                return "GLITTER";
            case 88:
                return "GRAFITE, 0,50 MM";
            case 89:
                return "GRAFITE,0,70 MM";
            case 90:
                return "GRAFITE, 0,90 MM";
            case 91:
                return "C�MERA VIDEOCONFER�NCIA";
            case 92:
                return "OX�METRO USO M�DICO";

            default:
                return "";
        }
    }

    #endregion Consumable
}
