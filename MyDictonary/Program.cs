using System;

class MyDictionary<TKey, TValue>
{
    public TKeay[] keys;
    public TValue[] values;
    public int count = 0;

    public MyDictionary()
    {
        keys = new TKey[0];
        values = new TValue[0];
        count = 0;
    }
    public void Add()
    {
        //Yeni bir geçici dizi oluşturuyoruz
        TKey[] tempKeys = new TKey[count + 1];
        TValue[] tempValues = new TValue[count + 1];

        //mevcut anahtar ve değerleri geçici diziye kopyala

        for(int i=0; i<count; i++)
        {
            tempKeys[i] = keys[i];
            tempValues[i] = values[i];
        }
        //Yeni anahtar ve değeri ekle
        tempKeys = keys;
        tempValues = values;

        //Anahtar ve değer dizilerini güncelle
        keys = tempKeys;
        values = tempValues;
    }
}

