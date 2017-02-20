using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
public class GrammarScript : MonoBehaviour {

    GrammarRecognizer grammerRecognizer;
    //private Dictionary<string, Color> colorLookup = new Dictionary<string, Color>
    //{
    //    {"red", Color.red }, {"blue", Color.blue }, {"black", Color.black},
    //    {"brown", new Color(0.65f, 0.16f, 0.16f)}, {"green", Color.green}, {"cyan", Color.cyan},
    //    {"purple", new Color(0.5f, 0.0f, 0.5f)}, {"yellow", Color.yellow}, {"white", Color.white},
    //    {"orange", new Color(1.0f, 0.65f, 0.0f)}, {"gray", Color.gray}, {"magenta", Color.magenta}
    //};

    private Dictionary<string, string> dictionary = new Dictionary<string, string>
    {
        
    };


    // Use this for initialization
    void Start()
    {
        // pass path of your grammar XML in the constructor
        grammerRecognizer = new GrammarRecognizer(Application.dataPath +"/StreamingAssets/SRGS/grammar.xml");
        grammerRecognizer.OnPhraseRecognized += OnGrammerRecognized;
        grammerRecognizer.Start();
    }

    void OnGrammerRecognized(PhraseRecognizedEventArgs args)
    {
         SemanticMeaning[] meanings = args.semanticMeanings;
    // do something
    }
}

