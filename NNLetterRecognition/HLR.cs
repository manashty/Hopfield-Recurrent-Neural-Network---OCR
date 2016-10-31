using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

namespace NNLetterRecognition
{
    public class Neuron
    {
        int _state;
        public Neuron(int state)
        {
            _state = state;
        }
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        public void Invert()
        {
            _state = -_state;
        }
    }
    public class HLR
    {
        List<Bitmap> _patterns;
        public List<Bitmap> Patterns
        {
            get { return _patterns; }
            set { _patterns = value; }
        }
        List<Neuron> _neurons;

        public List<Neuron> Neurons
        {
            get { return _neurons; }            
        }
        int n = 400;
        int size = 20;
        int[,] w;
        double energy;
        Neuron ne = new Neuron(0);
        public double Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public HLR()
        {
            _neurons = new List<Neuron>(n);
            _patterns = new List<Bitmap>();
            ne.State = 0;
            w = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                ne = new Neuron(0);
                //ne.State = 0;
                _neurons.Add(ne);
            }
        }
        Bitmap input;
        public void SetCurrentPattern(Bitmap p)
        {
            input = (Bitmap)p.Clone();
            List<Neuron> l = new List<Neuron>(n);
            for (int i = 0; i < n; i++)
            {
                l.Add(new Neuron(CtoI(p.GetPixel(i / 20, i % 20))));
            }
            _neurons = l;
            current = 0;
        }
        int current = 0;
        public bool Classify()
        {
            bool changed = false;         
            for (int i = current; i < n; i++)
            {
                int t = 0;
                for (int j = 0; j < n; j++)
                {
                    t += w[i, j] * _neurons[j].State;
                }
                if (_neurons[i].State * t < 0)
                {                    
                    _neurons[i].Invert();
                    UpdateEnergy();
                    changed = true;
                    current = i;
                    return changed;
                    
                }
            }
            return changed;            
        }
        public void AddPattern(Bitmap p)
        {
            _patterns.Add(p);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        w[i, j] += CtoI(p.GetPixel(i / 20, i % 20)) * CtoI(p.GetPixel(j / 20, j % 20));
                }
            }
        }
        /// <summary>
        /// Color to Int. Returns -1 for white, 1 for others.
        /// </summary>
        public static int CtoI(Color c)
        {
            return (c == Color.FromArgb(0,0,0,0)) ? -1 : 1;
        }
        private void UpdateEnergy()
        {
            energy = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i != j)
                        energy += w[i, j] * _neurons[i].State * _neurons[j].State;
            energy = -energy / 2;
        }
        
        public int MatchMSB()
        {
            ArrayList l = new ArrayList(_patterns.Count);
            KeyValuePair<int, double> answer;
            answer = new KeyValuePair<int, double>(0, MSB(_patterns[0], input));
            for (int i = 0; i < _patterns.Count; i++)
            {
                l.Add(new KeyValuePair<int, double>(i, MSB(_patterns[i], input)));
                if(((KeyValuePair<int, double>)l[i]).Value<(answer.Value))
                    answer = (KeyValuePair<int, double>)l[i];
            }
            return answer.Key;
        }

        private double MSB(Bitmap bitmap, Bitmap input)
        {
            double t = 0;
            for (int i = 0; i < 400; i++)
            {
                t += (Math.Pow(CtoI(input.GetPixel(i / 20, i % 20)) 
                    - CtoI(bitmap.GetPixel(i / 20, i % 20)), 2));
            }
            return t;
        }

    }
}
