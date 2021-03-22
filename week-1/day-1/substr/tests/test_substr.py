import unittest
from substr import substr


class SubStr(unittest.TestCase):

    def test_substr_happy_case(self):
        self.assertEqual(
            7, substr("this is what I'm searching in", "searching"))

    def test_substr_sad_case(self):
        self.assertEqual(-1, substr("this is what I'm searching in", "not"))

if __name__ == '__main__':
    unittest.main()
