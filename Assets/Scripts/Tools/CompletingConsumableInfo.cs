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
                return "ITEM 01 CADEIRAS PARA COPA(CA1) - ESPECIFICAÇÕES COMPLETAS VIDE ITEM 2.1.1 DO ANEXO I - TERMO DE REFERÊNCIA.RESUMO DAS ESPECIFICAÇÕES: CADEIRA FIXA COM ESTRUTURA EM AÇO CROMADO, APOIO DE BRAÇOS FIXO, ENCOSTO E ASSENTO EM POLIPROPILENO NA COR BRANCA.";
            case 2:
                return "2,00000 Unidade POLTRONA Poltrona, poltrona escritório MARCA: FLEXFORM ITEM DO PROCESSO: 00022 ITEM DE MATERIAL: 000150664";
            case 3:
                return "MESA, TIPO ESCRIVANINHA, MEDINDO 0,80 X 0,75 X 0,50.";
            case 4:
                return "ARMÁRIO PARA ESCRITÓRIO: Material MDF com PVC flexível e rodízio; Cor creme com 2 portas e mínimo 2 prateleiras internas; Fechadura com chave; Altura 165 cm; Largura 90 cm; Profundidade 45 cm";
            case 5:
                return "MACA CLÍNICA, MATERIAL AÇO INOXIDÁVEL, ACABAMENTO DA SUPERFÍCIE ESMALTADO, RODAS SEM RODÍZIOS, PÉS FIXO, COMPRIMENTO ATÉ 2,00 M, LARGURA CERCA DE 0,90 M, ALTURA CERCA DE 1,00 M, CAPACIDADE DE CARGA ATÉ 250 KG, COMPONENTES C/ SUPORTE PARA LENÇOL DESCARTÁVEL, CARACTERÍSTICAS ADICIONAIS CABECEIRA REGULÁVEL POR CREMALHEIRA, ACESSÓRIOS LEITO FIXO C/ COLCHÃO, COURVIN";
            case 6:
                return "ESCADA HOSPITALAR, USO MACA, MATERIAL AÇO INOXIDÁVEL, NÚMERO DEGRAUS 2, REVESTIMENTO DEGRAUS TAPETE ANTIDERRAPANTE, TIPO DEGRAUS FIXO, COR BRANCA";
            case 7:
                return "APARELHO AR CONDICIONADO, CAPACIDADE REFRIGERAÇÃO 24.000 BTU/H, TENSÃO 220 V, TIPO SPLIT, MODELO PAREDE, CARACTERÍSTICAS ADICIONAIS COM CONTROLE REMOTO SEM FIO";
            case 8:
                return "REFRIGERADOR: com capacidade mínima de 300l; Cor Branca; Sistema Frost Free; controle de temperatura que pode ser regulado; Compartimento Extra frio; Mínimo 2 prateleiras; Voltagem: 110V";
            case 9:
                return "FORNO MICRO-ONDAS: Especificações técnicas mínimas: capacidade mínima de 30l; funções de descongelamento e descongelamento de pratos prontos; prato giratório; trava de segurança; alarme sonoro; cor branca; Mensagens no “display” em português; Selo do Inmetro; Classificação de energia econômica; Voltagem: 110V.";
            case 10:
                return "BEBEDOURO DE PRESSÃO: na cor Inox; Com acionamento elétrico por meio de botões laterais e frontais de livre toque e indicação em Braile; Fixado na parede; Serve água natural e gelada; Bivolt:";
            case 11:
                return "BEBEDOURO ÁGUA GARRAFÃO, MATERIAL AÇO INOXIDÁVEL, TIPO ELÉTRICO DE COLUNA, CAPACIDADE 20 L, VOLTAGEM 110 V, CARACTERÍSTICAS ADICIONAIS GÁS ECOLÓGICO/2 TORNEIRAS(ÁGUA NATURAL/GELADA)SE R";
            case 12:
                return "VENTILADOR: coluna/pedestal; escritório/residencial; 200w; 1000 RPM a 1450 RPM; 110v; 0.2Kw/H; oscilante; controle velocidade; regulagem altura: mínimo de 50cm";
            case 13:
                return "CAIXA DE SOM ATIVA: 2 Vias ativas; 200 Watts 8 OHMS; 1 Falante de 12; 1 Driver titânio; Entrada USB; Entrada para Microfone P10 XLR; Entrada RCA; Saída de Linha XLR; Saída para caixa passiva; AVS Sistema automático de Voltagem; (110V e/ou bivolt); Dimensões mínimas (Altura 57,00 cm, Largura 39,0 cm e Profundidade 29,50 cm)";
            case 14:
                return "MESA DE SOM ANALÓGICA: 10 entradas.";
            case 15:
                return "MICROFONE SEM FIO(MÃO) : Receptor Sistema PLL Multi-Frequências com 48 Canais Pré-Definidos; - Display de Informações em LCD, Alcance de recepção média de 50m";
            case 16:
                return "APARELHO PURIFICADOR DE ÁGUA, TIPO DUPLA FILTRAGEM, VOLTAGEM 220 V, CAPACIDADE 2 L, VAZÃO 0,75 L/H, MATERIAL GABINETE METÁLICO/POLIPROPILENO, CAPACIDADE REFRIGERAÇÃO 2,20 L/H, CARACTERÍSTICAS ADICIONAIS ÁGUA GELADA E ÁGUA NATURAL/ TUBO AÇO INOXIDÁVEL/PO-, COR BRANCA";
            case 17:
                return "MULTÍMETRO, CARACTERÍSTICAS ADICIONAIS DISPLAY: 3 5/6 DÍGITOS, 6000 CONTAGENS, ILUMINAÇÃO, TIPO DIGITAL, TEMPERATURA 10 A 50°C OBSERVAÇÕES COMPLEMENTARES";
            case 18:
                return "TELEVISOR: com no mínimo as seguintes características: Smart TV; 32 polegadas; LED; Resolução HD; 1 USB; 1 HDMI; Conversor Digital";
            case 19:
                return "MONITOR: com no mínimo as seguintes características: Tipo LED; Tamanho da Tela: 19.5'; Formato de tela: 16:9 (widescreen).";
            case 20:
                return "ESTETOSCÓPIO, TIPO BIAURICULAR, ACESSÓRIOS OLIVAS ANATÔMICAS SILICONE, HASTE HASTE AÇO INOX, TUBO TUBO 'Y' SILICONE, AUSCULTADOR AUSCULTADOR AÇO INOX C/ ANEL DE BORRACHA, TAMANHO PEDIÁTRICO";
            case 21:
                return "CARRETA RODOVIÁRIA PARA TRANSPORTE DE BARCOS DE 05 A 06 METROS.CHASSI FABRICADO EM AÇO GALVANIZADO A FOGO, COR CINZA, COM BERÇO REGULÁVEL, TIPO ENGATE FIXAÇÃO AUTOMÁTICA E TRAVA DE SEGURANÇA, SISTEMA DE ILUMINAÇÃO EM LED E A PROVA D ÁGUA E TRIÂNGULO REFLETIVO.QUINCHO 1200 LBS, 544 KG COM CINTA DE 6 METROS.PRESENÇA DE ROLETES FACILITADORES COLOCAÇÃO DO BARCO.PARA-CHOQUE EXPANSÍVEL/REMOVÍV EL C/ ILUMINAÇÃO.";
            case 22:
                return "APARELHO RAIOS X, POTÊNCIA APARELHO 50 A 125 KV, TIPO APARELHO MÓVEL, C/ AMPOLAS DE RAIO X, APLICAÇÃO USO MÉDICO, TENSÃO ALIMENTAÇÃO 220 V, FREQUÊNCIA 60 HZ, CARACTERÍSTICAS ADICIONAIS GERADOR ALTA FREQUÊNCIA, CONTROLE DE KV E MAS, AC I, ADICIONAIS C/DESCARGA TEMPO CAPACITOR,C/ 300 MAS";
            case 23:
                return "DESFIBRILADOR, TIPO EXTERNO AUTOMÁTICO, RECURSOS INTEGRADOS MONITOR ECG, TIPO ONDA BIFÁSICA, TEMPO MÁXIMO CARGA ATÉ 10 S, MEMÓRIA GRAVA ECG,EVENTOS,SOM AMBIENTE, ALIMENTAÇÃO BATERIA LÍTIO, CAPACIDADE BATERIA MÍNIMO DE 200 DESCARGAS, COMPONENTE PÁS ADESIVAS DESCARTÁVEIS, COMPONENTES ADICIONAIS TECLA C/ MENSAGEM DE TEXTO, CARACTERÍSTICAS ADICIONAIS COMANDO DE VOZ, TIPO MÓDULO PORTÁTIL, C/ ALÇA TRANSPORTE, MALETA";
            case 24:
                return "DESUMIDIFICADOR PORTÁTIL: automático; com alças laterais e rodízios para facilitar a mobilidade; com umidostato para regulagem da umidade do ambiente; recipiente coletor de água com, no mínimo, 3 (três litros de capacidade); adaptador para mangueira; chave de liga/desliga; com parada automática quando o reservatório de água atingir o nível máximo e luz indicativa de reservatório cheio; capacidade para desumidificar ambientes de, no mínimo, 150m³; capacidade de condensação(24h) de, no mínimo, 10 litros de água; tensão/voltagem: 127V/60Hz";
            case 25:
                return "MICROCOMPUTADOR: com no mínimo as seguintes características: Processador com 3,0 GHZ; Memória Ram 8GB; Placa de vídeo 4GB, 128 bits; Disco Rígido de 1TB de armazenamento";
            case 26:
                return "DISPOSITIVO ARMAZENAMENTO FITA, CAPACIDADE ARMAZENAMENTO 48, VELOCIDADE TRANSFERÊNCIA 10.8 TB/H, COMPATIBILIDADE LTO-5, LTO-6, LTO7 E LTO-8, INTERFACE SAS, ALIMENTAÇÃO 127/240 V";
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
                return "ARMÁRIO PARA ESCRITÓRIO";
            case 5:
                return "MACA CLÍNICA";
            case 6:
                return "ESCADA HOSPITALAR";
            case 7:
                return "APARELHO AR CONDICIONADO";
            case 8:
                return "REFRIGERADOR";
            case 9:
                return "FORNO MICRO-ONDAS";
            case 10:
                return "BEBEDOURO DE PRESSÃO";
            case 11:
                return "BEBEDOURO ÁGUA GARRAFÃO";
            case 12:
                return "VENTILADOR";
            case 13:
                return "CAIXA DE SOM ATIVA";
            case 14:
                return "MESA DE SOM ANALÓGICA";
            case 15:
                return "MICROFONE SEM FIO(MÃO)";
            case 16:
                return "APARELHO PURIFICADOR DE ÁGUA";
            case 17:
                return "MULTÍMETRO";
            case 18:
                return "TELEVISOR 32";
            case 19:
                return "MONITOR";
            case 20:
                return "ESTETOSCÓPIO";
            case 21:
                return "CARRETA TRANSPORTE EMBARCAÇÃO";
            case 22:
                return "APARELHO RAIOS X MÓVEL";
            case 23:
                return "DESFIBRILADOR";
            case 24:
                return "DESUMIDIFICADOR PORTÁTIL 3L";
            case 25:
                return "MICROCOMPUTADOR";
            case 26:
                return "DISPOSITIVO ARMAZENAMENTO FITA 10.8 TB";
            case 27:
                return "Obra de Arte óleo sobre tela 86,5 cm x 61,6 cm";
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
                return "AÇUCAREIRO, MATERIAL AÇO INOXIDÁVEL, CAPACIDADE 300 G, CARACTERÍSTICAS ADICIONAIS COM TAMPA, COM PÁ PARA AÇÚCAR, FORMATO OVALOBSERVAÇÕES COMPLEMENTARES.";
            case 1:
                return "CAFÉ, APRESENTAÇÃO TORRADO EM GRÃO, INTENSIDADE MÉDIA, TIPO TRADICIONAL";
            case 2:
                return "CAFÉ, APRESENTAÇÃO TORRADO MOÍDO, INTENSIDADE SUAVE, TIPO TRADICIONAL, EMPACOTAMENTO VÁCUO";
            case 3:
                return "ÁGUA MINERAL NATURAL, TIPO SEM GÁS, MATERIAL EMBALAGEM PLÁSTICO, TIPO EMBALAGEM RETORNÁVEL";
            case 4:
                return "ADOÇANTE, ASPECTO FÍSICO LÍQUIDO, INGREDIENTES ESTÉVIA, TIPO DIETÉTICO MARCA: STEVITA ITEM DO PROCESSO: 00004 ITEM DE MATERIAL: 000236197";
            case 5:
                return "COPO DESCARTÁVEL, MATERIAL POLIPROPILENO, CAPACIDADE 200 ML, APLICAÇÃO LÍQUIDOS FRIOS E QUENTES, CARACTERÍSTICAS ADICIONAIS ATÓXICO, DE ACORDO C/ NORMA ABNT, NBR 14865, COR BRANCO";
            case 6:
                return "ADOÇANTE, ASPECTO FÍSICO LÍQUIDO, INGREDIENTES ESTÉVIA, TIPO DIETÉTICO MARCA: STEVITA ITEM DO PROCESSO: 00004 ITEM DE MATERIAL: 000236197";
            case 7:
                return "COADOR DESCARTÁVEL CAFÉ, MATERIAL PAPEL, TAMANHO 102 MARCA: MALU ITEM DO PROCESSO: 00019 ITEM DE MATERIAL: 000237589";
            case 8:
                return "CANETA ROMA EM PLÁSTICO, ESFEROGRÁFICA, COM ARTE, CONFORME SOLICITANTE.";
            case 9:
                return "CLIPE USO CIRÚRGICO, MATÉRIA PRIMA TITÂNIO, APLICAÇÃO* HEMOSTÁTICO, TAMANHO* MÉDIO- LARGO, ESTERILIDADE* ESTÉRIL, DESCARTÁVEL";
            case 10:
                return "BORRACHA BRANCA 20 CX/20 UND LEOELEO";
            case 11:
                return "CANETAS E MARCADORES, COM PONTA DE FELTRO OU COM OUTRAS PONTAS POROSAS";
            case 12:
                return "MOLAS PARA PAPÉIS, OUTROS OBJETOS DE ESCRITÓRIO, DE METAIS COMUNS";
            case 13:
                return "OUTROS ARTIGOS SEMELHANTES A CAIXAS, ENGRADADOS, ETC, DE PLÁSTICO";
            case 14:
                return "OUTROS PRODUTOS DE QUALQUER ESPÉCIE UTILIZADOS COMO COLAS OU ADESIVOS, ACONDICIONADOS PARA VENDA A RETALHO COMO COLAS OU ADESIVOS, COM PESO LÍQUIDO NÃO SUPERIOR A 1 KG";
            case 15:
                return "OUTRAS OBRAS DE PLÁSTICOS";
            case 16:
                return "MOLAS PARA PAPÉIS, OUTROS OBJETOS DE ESCRITÓRIO, DE METAIS COMUNS";
            case 17:
                return "SERINGA, MATERIAL VIDRO, CAPACIDADE 10 ML, TIPO BICO BICO CENTRAL LUER LOCK OUSLIP, ADICIONAL GRADUADA, NUMERADA, ESTERILIDADE ESTERILIZÁVEL";
            case 18:
                return "FRASCO 10,00 ML CLORETO DE SÓDIO, CONCENTRAÇAO 0,9 , FORMA FARMACEUTICA SOLUÇÃO ESTÉRIL NÃO INJETÁVEL";
            case 19:
                return "ROLO 10,00 M FITA HOSPITALAR, TIPO MICROPOROSA, MATERIAL DORSO EM NÃO TECIDO, COMPONENTES ADESIVO ACRÍLICO, DIMENSÕES CERCA DE 25 MM, CARACTERÍSTICAS ADICIONAIS HIPOALERGÊNICO, COR COM COR";
            case 20:
                return "ATADURA GESSADA, MATERIAL TELA TIPO GIRO INGLÊS, 100% ALGODÃO, LARGURA 10 CM, COMPRIMENTO 300 CM, CARACTERÍSTICAS ADICIONAIS IMPREGNADA C/GESSO COLOIDAL, SECAGEM ULTRA RÁPIDA";
            case 21:
                return "COLETOR MATERIAL PÉRFURO-CORTANTE, MATERIAL PAPELÃO, CAPACIDADE TOTAL 13 L, ACESSÓRIOS ALÇAS RÍGIDAS E TAMPA, COMPONENTES ADICIONAIS REVESTIMENTO INTERNO EM POLIETILENO ALTA DENSIDAD E, TIPO USO DESCARTÁVEL";
            case 22:
                return "UNIFORMES, TECIDOS E AVIAMENTOS";
            case 23:
                return "LUVA PARA PROCEDIMENTO NÃO CIRÚRGICO, MATERIAL LÁTEX NATURAL ÍNTEGRO E UNIFORME, TAMANHO PEQUENO, CARACTERÍSTICAS ADICIONAIS LUBRIFICADA COM PÓ BIOABSORVÍVEL, DESCARTÁVEL, APRESENTAÇÃO ATÓXICA, TIPO AMBIDESTRA, TIPO USO DESCARTÁVEL, MODELO FORMATO ANATÔMICO, FINALIDADE RESISTENTE À TRAÇÃO";
            case 24:
                return "ÁLCOOL ETÍLICO, TIPO HIDRATADO, TEOR ALCOÓLICO 70%_(70 GL), APRESENTAÇÃO GEL";
            case 25:
                return "MÁSCARA CIRÚRGICA, TIPO NÃO TECIDO,3 CAMADAS,PREGAS HORIZONTAIS, ATÓXICA, TIPO FIXAÇÃO COM ELÁSTICO, CARACTERÍSTICAS ADICIONAIS CLIP NASAL EMBUTIDO,HIPOALERGÊNICA, TIPO USO DESCARTÁVEL";
            case 26:
                return "MÁSCARA, TIPO RESPIRADOR, TIPO FIXAÇÃO DUPLO SISTEMA DE TIRAS ELÁSTICAS, APLICAÇÃO FILTRAGEM BACTERIANA 99%, TAMANHO REGULAR, CARACTERÍSTICAS ADICIONAIS CLASSE PFF2(POEIRAS, FUMOS, NÉVOAS TÓXICAS), FORMATO EM CONCHA, DUPLA CAMADA";
            case 27:
                return "TOALHA DE PAPEL, TOALHA PAPEL - MAO";
            case 28:
                return "SABONETE LÍQUIDO, ASPECTO FÍSICO LÍQUIDO CREMOSO PEROLADO, COR BRANCA, ACIDEZ NEUTRO PH, APLICAÇÃO COMERCIAL";
            case 29:
                return "FITA HOSPITALAR, TIPO ESPARADRAPO, IMPERMEÁVEL, MATERIAL ALGODÃO, COMPONENTES ADESIVO À BASE DE ZINCO, DIMENSÕES CERCA DE 10 CM, CARACTERÍSTICAS ADICIONAIS HIPOALERGÊNICO, COR COM COR";
            case 30:
                return "ESTETOSCÓPIO, TIPO BIAURICULAR, ACESSÓRIOS OLIVAS ANATÔMICAS SILICONE, HASTE HASTE AÇO INOX, TUBO TUBO Y SILICONE, AUSCULTADOR AUSCULTADOR AÇO INOX C/ ANEL DE BORRACHA, TAMANHO PEDIÁTRICO";
            case 31:
                return "LANCETA, MATERIAL LÂMINA AÇO INOXIDÁVEL, PONTA AFIADA,TRIFACETADA, USO DESCARTÁVEL, CARACTERÍSTICAS ADICIONAIS ESTÉRIL, EMBALAGEM INDIVIDUAL, TIPO COM SISTEMA RETRÁTIL";
            case 32:
                return "MOLDURAS: para diplomas de honrarias, confeccionada em madeira 4,5 cm de largura, cor dourada com fundo em MDF, pendurador triângulo horizontal, prendedores flex point, vidro antireflexo, tamanho 21 x 30 cm";
            case 33:
                return "MOLDURAS: para diplomas de honrarias, confeccionada em madeira 4,5 cm de largura, cor dourada com fundo em MDF, pendurador triângulo horizontal, prendedores flex point, vidro antireflexo, tamanho 42 x 30 cm";
            case 34:
                return "AGENDA";
            case 35:
                return "ALFINETE MAPA, MATERIAL METAL, TRATAMENTO SUPERFICIAL GALVANIZADO, MATERIAL CABEÇA PLÁSTICO, FORMATO CABEÇA REDONDO, COR AZUL, COMPRIMENTO 15 MM, APLICAÇÃO MAPA";
            case 36:
                return "ALMOFADA CARIMBO, MATERIAL CAIXA PLÁSTICO/METAL, MATERIAL ALMOFADA ESPONJA ABSORVENTE REVESTIDA DE TECIDO, TAMANHO GRANDE, COR AZUL, TIPO ENTINTADA";
            case 37:
                return "APAGADOR QUADRO BRANCO, MATERIAL BASE FELTRO, MATERIAL CORPO PLÁSTICO, COMPRIMENTO 15 CM, LARGURA 6 CM, ALTURA 5 CM";
            case 38:
                return "APONTADOR LÁPIS, MATERIAL METAL E PLÁSTICO, TIPO ESCOLAR, CARACTERÍSTICAS ADICIONAIS COM DEPÓSITO";
            case 39:
                return "BARBANTE, MATERIAL RÁFIA, COR BRANCA, CARACTERÍSTICAS ADICIONAIS FIBRA NATURAL.";
            case 40:
                return "BARBANTE ALGODÃO";
            case 41:
                return "BLOCO RECADO, MATERIAL PAPEL, COR AMARELO, LARGURA 38 MM, COMPRIMENTO 50 MM, TIPO REMOVÍVEL, CARACTERÍSTICAS ADICIONAIS AUTO-ADESIVO";
            case 42:
                return "BLOCO RECADO, MATERIAL PAPEL, COR AMARELA, LARGURA 76 MM, COMPRIMENTO 76 MM, CARACTERÍSTICAS ADICIONAIS AUTO-ADESIVO, POST IT, QUANTIDADE FOLHAS 100 UN";
            case 43:
                return "BOBINA PAPEL SENHA, MATERIAL PAPEL TÉRMICO, LARGURA 79 MM, COMPRIMENTO 40 M, APLICAÇÃO IMPRESSORA GERENCIADORA DE FILA, CARACTERÍSTICAS ADICIONAIS DIÂMETRO 60MM E TUBETE 12MM";
            case 44:
                return "BORRACHA APAGADORA ESCRITA, MATERIAL BORRACHA, COMPRIMENTO 50 MM, LARGURA 18 MM, ALTURA 6 MM, COR AZUL E VERMELHA, APLICAÇÃO PARA LÁPIS E TINTA";
            case 45:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, MATERIAL CAPA PAPELÃO, APRESENTAÇÃO BROCHURA, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 210 MM, LARGURA 150 MM";
            case 46:
                return "CANETA ESFEROGRÁFICA, MATERIAL PLÁSTICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LATÃO COM ESFERA DE TUNGSTÊNIO, TIPO ESCRITA MÉDIA, COR TINTA AZUL, CARACTERÍSTICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIFÍCIO LATERAL";
            case 47:
                return "CANETA ESFEROGRÁFICA, MATERIAL PLÁSTICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LATÃO COM ESFERA DE TUNGSTÊNIO, TIPO ESCRITA MÉDIA, COR TINTA PRETA, CARACTERÍSTICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIFÍCIO LATERAL";
            case 48:
                return "CANETA ESFEROGRÁFICA, MATERIAL PLÁSTICO, QUANTIDADE CARGAS 1 UN, MATERIAL PONTA LATÃO COM ESFERA DE TUNGSTÊNIO, TIPO ESCRITA MÉDIA, COR TINTA VERMELHA, CARACTERÍSTICAS ADICIONAIS MATERIAL TRANSPARENTE E COM ORIFÍCIO LATERAL";
            case 49:
                return "CANETA HIDROGRÁFICA, MATERIAL PLÁSTICO, MATERIAL PONTA FELTRO, APLICAÇÃO PAPEL, CARACTERÍSTICAS ADICIONAIS JUMBO 12 CORES E ESTOJO COM ZIP.";
            case 50:
                return "PINCEL MARCADOR PERMANENTE CD, MATERIAL PLÁSTICO, TIPO PONTA FELTRO, COR TINTA AZUL";
            case 51:
                return "CANETA MARCA-TEXTO, MATERIAL PLÁSTICO, TIPO PONTA CHANFRADA, COR FLUORESCENTE AMARELA, CARACTERÍSTICAS ADICIONAIS TRAÇO 4 MM";
            case 52:
                return "CANETA MARCA-TEXTO, MATERIAL PLÁSTICO, TIPO PONTA FLUORESCENTE, COR LARANJA";
            case 53:
                return "CANETA MARCA-TEXTO, MATERIAL PLÁSTICO, TIPO PONTA FLUORESCENTE, COR ROSA";
            case 54:
                return "CANETA MARCA-TEXTO, MATERIAL PLÁSTICO, TIPO PONTA FLUORESCENTE, COR VERDE.";
            case 55:
                return "CANETA DESENHO ARQUITETÔNICO, MATERIAL CORPO PLÁSTICO, MATERIAL PONTA METAL, CARACTERÍSTICAS ADICIONAIS TINTA:NANQUIM/ USO:DESCARTAVEL, TAMANHO PONTA 0,30 MM, COR PRETA";
            case 56:
                return "CARTOLINA, MATERIAL CELULOSE VEGETAL, GRAMATURA 150 G/M2, COMPRIMENTO 660 MM, LARGURA 500 MM, COR AZUL";
            case 57:
                return "GRAMPEADOR, MATERIAL METAL, TIPO MESA, CAPACIDADE 25 FL, TAMANHO GRAMPO 26/6, CARACTERÍSTICAS ADICIONAIS BASE DE BORRACHA";
            case 58:
                return "LÁPIS BORRACHA, MATERIAL MADEIRA, DIÂMETRO CARGA 4 MM, FORMATO CORPO CILÍNDRICO, DIÂMETRO CORPO 8 MM, COMPRIMENTO TOTAL 175 MM, APLICAÇÃO TINTA/ GRAFITE";
            case 59:
                return "LIVRO PROTOCOLO, MATERIAL PAPEL OFF-SET, QUANTIDADE FOLHAS 100 FL, COMPRIMENTO 230 MM, LARGURA 170 MM, TIPO CAPA DURA, CARACTERÍSTICAS ADICIONAIS COM FOLHAS PAUTADAS E NUMERADAS SEQÜENCIALMENTE, MATERIAL CAPA PAPELÃO, GRAMATURA FOLHAS 54 G/M2";
            case 60:
                return "LUPA, TIPO PORTÁTIL, FORMATO REDONDA, FAIXA AMPLIAÇÃO MÍNIMO 10 VEZES, DIÂMETRO 6 CM, MATERIAL CABO METAL, CARACTERÍSTICAS ADICIONAIS REGULÁVEL E ARTICULADO, DE MESA";
            case 61:
                return "MOLHA-DEDOS, MATERIAL BASE PLÁSTICO, MATERIAL TAMPA PLÁSTICO, MATERIAL CARGA MASSA, TAMANHO 12, VALIDADE CARGA 1 ANO, CARACTERÍSTICAS ADICIONAIS CONTÉM GLICERINA E NÃO MANCHA";
            case 62:
                return "PUNÇÃO - ESCRITA BRAILE, MATERIAL CABO PLÁSTICO, MATERIAL PONTEIRA AÇO, FORMATO ESFÉRICO, DIÂMETRO 25 MM";
            case 63:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 60 CM, LARGURA 45 CM , USO ARTÍSTICO";
            case 64:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 50 CM, LARGURA 35 CM , USO ARTÍSTICO";
            case 65:
                return "TELA DE PINTURA, MATERIAL TECIDO, COR BRANCA, COMPRIMENTO 60 CM, LARGURA 60 CM , USO ARTÍSTICO";
            case 66:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, MATERIAL CAPA PAPELÃO, APRESENTAÇÃO BROCHURA, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 210 MM, LARGURA 150 MM";
            case 67:
                return "CADERNO, MATERIAL CELULOSE VEGETAL, APRESENTAÇÃO ESPIRAL, QUANTIDADE FOLHAS 96 FL, COMPRIMENTO 202 MM, LARGURA 140 MM, CARACTERÍSTICAS ADICIONAIS FOLHA PAUTADA E CAPA DURA";
            case 68:
                return "CALCULADORA ELETRÔNICA, NOME CALCULADORA ELETRÔNICA";
            case 69:
                return "CAPA ENCADERNAÇÃO, MATERIAL PVC- CLORETO DE POLIVINILA, TIPO A4, COR INCOLOR, FORMATO 210 X 297 MM, LOMBADA 5 MM, CARACTERÍSTICAS ADICIONAIS LONG STEELCRYSTAL";
            case 70:
                return "CHAVEIRO, MATERIAL PLÁSTICO, FORMATO RETANGULAR, TAMANHO 5,8 X 2,60 X 0,5 CM, COR SORTIDA, APLICAÇÃO IDENTIFICAÇÃO CHAVES, CARACTERÍSTICAS ADICIONAIS TIPO CAIXA, ETIQUETA INTERNA DE PAPEL";
            case 71:
                return "COLA, COR BRANCA, APLICAÇÃO PAPEL, CARACTERÍSTICAS ADICIONAIS INSTANTÂNEA, TIPO LÍQUIDO";
            case 72:
                return "COLCHETE FIXAÇÃO, MATERIAL AÇO, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO Nº 3";
            case 73:
                return "COLCHETE FIXAÇÃO, MATERIAL AÇO, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO Nº 5";
            case 74:
                return "COLCHETE FIXAÇÃO, MATERIAL AÇO, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO Nº 6";
            case 75:
                return "COLCHETE FIXAÇÃO, MATERIAL AÇO, TRATAMENTO SUPERFICIAL LATONADO, TAMANHO Nº 7";
            case 76:
                return "CORRETIVO LÍQUIDO, MATERIAL BASE D'ÁGUA- SECAGEM RÁPIDA, APRESENTAÇÃO FRASCO, APLICAÇÃO PAPEL COMUM ML, VOLUME 18 ML";
            case 77:
                return "CINTA ELÁSTICA, MATERIAL BORRACHA, FORMA CIRCULAR, COR NATURAL, APLICAÇÃO ORGANIZAÇÃO MATERIAL EXPEDIENTE";
            case 78:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 340 MM, COR PARDA, LARGURA 240 MM";
            case 79:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 242 MM, COR PARDA, LARGURA 336 MM";
            case 80:
                return "ENVELOPE, MATERIAL PAPEL KRAFT, GRAMATURA 80 G/M2, TIPO SACO COMUM, COMPRIMENTO 360 MM, COR PARDA, IMPRESSÃO BAIXO-RELEVO, LARGURA 260 MM";
            case 81:
                return "ENVELOPE PLÁSTICO, COMPRIMENTO 32 CM, LARGURA 24 CM, CARACTERÍSTICAS ADICIONAIS COM 4 FUROS, APLICAÇÃO PASTA CATÁLOGO, MATERIAL PLÁSTICO";
            case 82:
                return "ENVELOPE PLÁSTICO, TIPO PLÁSTICO POLIETILENO ALTA TRANSPARÊNCIA, COMPRIMENTO 316 MM, LARGURA 240 MM, COR BRANCA, CARACTERÍSTICAS ADICIONAIS SEM FUROS, TIPO SACO, APLICAÇÃO ACONDICIONAMENTO DE DOCUMENTOS, GRAMATURA 80 G/M2";
            case 83:
                return "ESCALÍMETRO, MATERIAL PLÁSTICO, TIPO ESCALA TRIPLO DECÍMETRO, TAMANHO 30 CM, ESCALA GRADUAÇÃO 1:20, 1:25, 1:50, 1:75, 1:100 E 1:125";
            case 84:
                return "ETIQUETA ADESIVA, MATERIAL PAPEL, COR BRANCA, LARGURA 60 MM, COMPRIMENTO 170 MM, TIPO AUTO-ADESIVA, CARACTERÍSTICAS ADICIONAIS FOLHA A4 C/ 4 ETIQUETAS";
            case 85:
                return "PAPEL AUTO-ADESIVO, MATERIAL PLÁSTICO, TIPO CONTACT, COR INCOLOR, GRAMATURA 60 G/M2, LARGURA 450 MM, ACABAMENTO SUPERFICIAL BRILHANTE, COMPRIMENTO FOLHA 2.500 MM, TRANSMITÂNCIA TRANSPARENTE";
            case 86:
                return "RÉGUA GABARITO, MATERIAL ACRÍLICO, APLICAÇÃO DIAGRAMAÇÃO, COR INCOLOR";
            case 87:
                return "GLITTER, MATERIAL PVC- CLORETO DE POLIVINILA, ASPECTO FÍSICO PARTÍCULAS METALIZADAS, COR SORTIDA, APLICAÇÃO DECORAÇÃO/ROUPA/ARTESANATO/FANTASIA/FLOR E ISOPOR";
            case 88:
                return "GRAFITE, DIÂMETRO 0,50 MM";
            case 89:
                return "GRAFITE, DIÂMETRO 0,70 MM";
            case 90:
                return "GRAFITE, DIÂMETRO 0,90 MM";
            case 91:
                return "CÂMERA WEBCAM HD 720P C/MICROFONE: VÍDEO CHAMADA HD[1280 X 720 PIXELS] COM SI STEMA RECOMENDADO.CAPTURA DE VÍDEO: ATÉ 1280 X 720 PIXELS.FOTOS: ATÉ 3,0 MEG APIXELS [COM OTIMIZAÇÃO DO SOFTWARE]. MICROFONE EMBUTIDO COM A TECNOLOGIA RIGH TSOUND.USB 2.0 DE ALTA VELOCIDADE CERTIFICADO. CLIPE UNIVERSAL QUE SE AJUSTA A LAPTOPS, MONITORES LCD OU CRT.";
            case 92:
                return "OXÍMETRO USO MÉDICO, TIPO DEDO, FAIXA MEDIÇÃO SATURAÇÃO 1 0 A 100%, FAIXA MEDIÇÃO PULSO 1 CERCA DE 20 A 250 BPM, AUTONOMIA SISTEMA 1 CERCA 24 H, ALIMENTAÇÃO PILHA, ACESSÓRIOS C/ SENSOR";

            default:
                return "";
        }
    }

    public string GetItemName(int newIndex)
    {
        switch (newIndex)
        {
            case 0:
                return "AÇUCAREIRO";
            case 1:
                return "CAFÉ INTENSIDADE MÉDIA";
            case 2:
                return "CAFÉ INTENSIDADE SUAVE";
            case 3:
                return "ÁGUA MINERAL NATURAL";
            case 4:
                return "ADOÇANTE";
            case 5:
                return "COPO DESCARTÁVEL";
            case 6:
                return "ADOÇANTE, ASPECTO FÍSICO LÍQUIDO";
            case 7:
                return "COADOR DESCARTÁVEL CAFÉ";
            case 8:
                return "CANETA ESFEROGRÁFICA";
            case 9:
                return "CLIPE USO CIRÚRGICO";
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
                return "CLORETO DE SÓDIO";
            case 19:
                return "FITA HOSPITALAR, TIPO MICROPOROSA";
            case 20:
                return "ATADURA GESSADA";
            case 21:
                return "COLETOR MATERIAL PÉRFURO-CORTANTE,";
            case 22:
                return "AVENTAL HOSPITALAR";
            case 23:
                return "LUVA PARA PROCEDIMENTO NÃO CIRÚRGICO";
            case 24:
                return "ÁLCOOL ETÍLICO 70% GEL";
            case 25:
                return "MÁSCARA CIRÚRGICA";
            case 26:
                return "MÁSCARA CIRÚRGICA";
            case 27:
                return "TOALHA DE PAPEL";
            case 28:
                return "SABONETE LÍQUIDO";
            case 29:
                return "FITA HOSPITALAR";
            case 30:
                return "ESTETOSCÓPIO";
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
                return "APONTADOR LÁPIS";
            case 39:
                return "BARBANTE";
            case 40:
                return "BARBANTE ALGODÃO";
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
                return "CANETA ESFEROGRÁFICA  AZUL";
            case 47:
                return "CANETA ESFEROGRÁFICA PRETA";
            case 48:
                return "CANETA ESFEROGRÁFICA VERMELHA";
            case 49:
                return "CANETA HIDROGRÁFICA";
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
                return "CANETA DESENHO ARQUITETÔNICO";
            case 56:
                return "CARTOLINA AZUL";
            case 57:
                return "GRAMPEADOR";
            case 58:
                return "LÁPIS BORRACHA";
            case 59:
                return "LIVRO PROTOCOLO";
            case 60:
                return "LUPA";
            case 61:
                return "MOLHA-DEDOS";
            case 62:
                return "PUNÇÃO - ESCRITA BRAILE";
            case 63:
                return "TELA DE PINTURA 45X60";
            case 64:
                return "TELA DE PINTURA 35X50";
            case 65:
                return "TELA DE PINTURA 60X60";
            case 66:
                return "CADERNO, APRESENTAÇÃO BROCHURA,";
            case 67:
                return "CADERNO, APRESENTAÇÃO ESPIRAL";
            case 68:
                return "CALCULADORA ELETRÔNICA";
            case 69:
                return "CAPA ENCADERNAÇÃO";
            case 70:
                return "CHAVEIRO";
            case 71:
                return "COLA, COR BRANCA, TIPO LÍQUIDO";
            case 72:
                return "COLCHETE FIXAÇÃO Nº 3";
            case 73:
                return "COLCHETE FIXAÇÃO Nº 5";
            case 74:
                return "COLCHETE FIXAÇÃO Nº 6";
            case 75:
                return "COLCHETE FIXAÇÃO Nº 7";
            case 76:
                return "CORRETIVO LÍQUIDO";
            case 77:
                return "CINTA ELÁSTICA  100G";
            case 78:
                return "ENVELOPE 340 MM PO 240MM";
            case 79:
                return "ENVELOPE  242 MM POR 336MM";
            case 80:
                return "ENVELOPE  360 MM POR 260 MM";
            case 81:
                return "ENVELOPE PLÁSTICO, 32 CM,POR 24 CM,";
            case 82:
                return "ENVELOPE PLÁSTICO,316 MM, POR 240 MM";
            case 83:
                return "ESCALÍMETRO";
            case 84:
                return "ETIQUETA ADESIVA";
            case 85:
                return "PAPEL AUTO-ADESIVO";
            case 86:
                return "RÉGUA GABARITO";
            case 87:
                return "GLITTER";
            case 88:
                return "GRAFITE, 0,50 MM";
            case 89:
                return "GRAFITE,0,70 MM";
            case 90:
                return "GRAFITE, 0,90 MM";
            case 91:
                return "CÂMERA VIDEOCONFERÊNCIA";
            case 92:
                return "OXÍMETRO USO MÉDICO";

            default:
                return "";
        }
    }

    #endregion Consumable
}
